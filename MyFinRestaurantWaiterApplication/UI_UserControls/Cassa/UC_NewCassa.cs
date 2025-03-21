using System;
using System.Linq;
using System.Drawing;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Collections.Generic;
using MyFinCassa.UC;
using MyFinCassa.Model;
using MyFinCassa.Helper;
using MyFinCassa.UI_Forms;
using MyFinCassa.Database;
using MyFinCassa.Properties;

namespace MyFinCassa.UI_UserControls.Cassa
{
    public partial class UC_NewCassa : UserControl
    {
        private List<UC_OrderCard> myUserControls = new List<UC_OrderCard>();
        private const int WITH_MYSELF_INDEX = -999;

        private List<Order> myOrders;
        private Dictionary<int, Tables> tableDict;
        private Dictionary<int, Hall> hallDict;
        private Dictionary<int, User> userDict;
        private int myUserRole;
        private string currency;

        private int currentPage = 0;
        private readonly int itemsPerPage = 15;
        private int totalPages = 1;

        public UC_NewCassa()
        {
            InitializeComponent();
            InitForm();
        }

        private async void InitForm()
        {
            // Параллельное выполнение асинхронных операций
            var userTask = new User().OnSelectUserAsync(Settings.Default.user_id);
            var currencyTask = new Currency().OnGetCurrencyValueAsync();
            var tablesTask = new Tables().OnLoadAsync();
            var hallsTask = new Hall().OnLoadAllAsync();
            var allUsersTask = new User().OnAllUserAsync(true);

            await Task.WhenAll(userTask, currencyTask, tablesTask, hallsTask, allUsersTask);

            var myUser = await userTask;
            myUserRole = myUser.user_role;
            txtName.Text = myUser.user_name;

            await new Order().DeleteNewOrdersAsync();

            var tables = await tablesTask;
            var halls = await hallsTask;
            var user = await allUsersTask;
            currency = await currencyTask;

            // Определение заказов
            myOrders = myUserRole == (int)EnumUserRole.Waiter
                ? await new Order().OnSelectMyOrdersCassaAsync(myUser.user_id)
                : await new Order().OnSelectAllOrdersCassaAsync();

            // Обновление заказов с использованием Join
            tableDict = tables.ToDictionary(t => t.table_id);
            hallDict = halls.ToDictionary(h => h.hall_id);
            userDict = user.ToDictionary(u => u.user_id);

            foreach (var order in myOrders)
            {
                if (tableDict.TryGetValue(order.order_table, out var table))
                {
                    order.tables = table;
                    if (hallDict.TryGetValue(table.table_hall_id, out var hall))
                    {
                        order.tables.hall = hall;
                    }
                }

                if (userDict.TryGetValue(order.order_user, out var orderUser))
                {
                    order.user = orderUser;
                }
            }

            InitUC(myOrders);
            ShowControlsOnPage(0);

            ManageAccessByUser(myUserRole);
            ShiftMaxenation();
            SetUpCmbs();
            UpdateSumma();
            PrintFormMatcher();

            timer1.Start();
            timer2.Start();
        }

        private void InitUC(List<Order> ordersToCard)
        {
            // Создание карточек заказов и добавление их в myUserControls
            var orderCards = ordersToCard.Select(order => CreateOrderCard(order)).ToList();

            // Убираем возможные null
            myUserControls.AddRange(orderCards.Where(card => card != null));

            // Добавление дополнительных карточек, если это необходимо
            AddExtraCards(ordersToCard.Count);
        }

        private UC_OrderCard CreateOrderCard(Order order)
        {
            var orderCard = new UC_OrderCard(currency)
            {
                ContextMenuStrip = contextMenu,
                Dock = DockStyle.Fill,
            };
            orderCard.InitOrder(order);
            AssignClickHandlerToButtons(orderCard);
            AssignSwipeHandler(orderCard);
            return orderCard;
        }

        private void AddExtraCards(int currentCardCount)
        {
            //int requiredUserControl = Math.Max(itemsPerPage, (currentCardCount / itemsPerPage + 1) * itemsPerPage);
            int requiredUserControl = (currentCardCount / itemsPerPage + 1) * itemsPerPage;
            for (int i = currentCardCount; i < requiredUserControl; i++)
            {
                var btnCard = new UC_OrderCard(currency)
                {
                    Dock = DockStyle.Fill,
                };
                btnCard.InitAddButton();
                AssignClickHandlerToButtons(btnCard);
                AssignSwipeHandler(btnCard);
                myUserControls.Add(btnCard);
            }
            totalPages = (myUserControls.Count + itemsPerPage - 1) / itemsPerPage;
            UpdateNavigationDisplay(currentPage);
            //CalculatePages();
        }

        private async void PrintFormMatcher()
        {
            if (await new CassaSettings().IsPrinterCookingOutputAsync())
            {
                PrintCoordinator printForm = (PrintCoordinator)Application.OpenForms["PrintForm"];
                if (printForm == null)
                {
                    PrintCoordinator printCoordinator = new PrintCoordinator
                    {
                        Name = "PrintForm"
                    };
                    printCoordinator.Show();
                }
            }
        }

        private async void SetUpCmbs()
        {
            List<User> users = new List<User>
            {
                new User() { user_name = "Показать все" },
            };
            users.AddRange(await new User().OnAllUserAsync());
            cmbUser.ValueMember = "user_id";
            cmbUser.DisplayMember = "user_name";
            cmbUser.DataSource = users;

            cmbUser.SelectedIndexChanged += CmbFiltersChange;
        }

        public async void ShiftMaxenation()
        {
            if (Settings.Default.change_id == 0)
            {
                txtShift.Text = "Смена закрыта";
            }
            else
            {
                Shift change = await new Shift().OnSelectShiftOpenAsync(Settings.Default.user_id);

                if (change == null)
                {
                    txtShift.Text = "Смена закрыта";
                }
                else
                {
                    txtShift.Text = $"Смена открыта: {change.shift_date_open}";
                }
            }
        }

        private void ManageAccessByUser(int myUserRole)
        {
            // Устанавливаем начальные значения видимости
            pnlUserFilter.Visible = false;
            menuItemPay.Visible = false;
            menuItemCancel.Visible = false;

            // Настройка доступа в зависимости от роли пользователя
            switch (myUserRole)
            {
                case (int)EnumUserRole.Admin:
                    pnlUserFilter.Visible = true;
                    menuItemPay.Visible = true;
                    menuItemCancel.Visible = true;
                    break;
                case (int)EnumUserRole.Cashier:
                    pnlUserFilter.Visible = true;
                    menuItemPay.Visible = true;
                    break;
                case (int)EnumUserRole.Waiter:
                    btnCassa.Visible = false;
                    break;
                case (int)EnumUserRole.Manager:
                    // Для менеджера только menuItemCancel остается невидимым
                    pnlUserFilter.Visible = true;
                    menuItemPay.Visible = true;
                    break;
            }
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var orders = await new Order().OnLoadNewOrdersAsync();
            if (orders.Count > 0)
            {
                await new Order().DeleteNewOrdersAsync();
                foreach (Order order in orders)
                {
                    var emptyCard = myUserControls.FirstOrDefault(c => c.Tag == null);
                    if (emptyCard != null)
                    {
                        CreateOrderCard(emptyCard, order);
                    }
                }
            }
            timer1.Start(); 
        }

        private void UpdateSumma()
        {
            double summa = 0;
            foreach (var orderCard in myUserControls)
            {
                if (orderCard.Tag is Order orderInCard)
                {
                    summa += orderCard.fullPrice;
                }
            }
            txtSumma.Text = $"{summa:f2} {currency}";
        }

        private void CmbFiltersChange(object sender, EventArgs e)
        {
            if (myOrders == null || myOrders.Count == 0)
            {
                return;
            }
            int selectedUserId = (cmbUser.SelectedItem as User)?.user_id ?? 0;

            var filteredOrders = myOrders.Where(order =>
                (selectedUserId == 0 || order.user.user_id == selectedUserId)).ToList();

            UpdateOrderCards(filteredOrders);
        }

        private void UpdateOrderCards(List<Order> filteredOrders)
        {
            foreach (var orderCard in myUserControls)
            {
                if (orderCard.Tag is Order orderInCard)
                {
                    var order = filteredOrders.FirstOrDefault(o => o.order_id == orderInCard.order_id);
                    if (order == null)
                    {
                        orderCard.TemporablyInitButton();
                    }
                    else
                    {
                        orderCard.TemporablyInitCard();
                    }
                }
            }
        }

        private void AssignSwipeHandler(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.MouseDown += MouseDownHandler;
                control.MouseUp += MouseUpHandler;

                if (control.HasChildren)
                {
                    AssignSwipeHandler(control);
                }
            }
        }

        private Point mouseDownPoint;
        private const int SwipeTheshold = 200;
        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            mouseDownPoint = e.Location;
        }

        private void MouseUpHandler(object sender, MouseEventArgs e)
        {
            int deltaX = e.Location.X - mouseDownPoint.X;

            if (Math.Abs(deltaX) > SwipeTheshold)
            {
                if (deltaX < 0) btnNextPage.PerformClick();
                else btnPreviousPage.PerformClick();
            }
        }

        private void AssignClickHandlerToButtons(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                switch (control)
                {
                    case Guna2ImageButton button:
                        button.Click += BtnAddOrder_Click;
                        break;
                    case FlowLayoutPanel panel:
                        panel.DoubleClick += BtnDozakaz;
                        break;
                    case Label label when label.Name == "txtPrice":
                        label.Click += BtnPay;
                        break;
                }

                if (control.HasChildren)
                {
                    AssignClickHandlerToButtons(control);
                }
            }
        }


        private async void BtnPay(object sender, EventArgs e)
        {
            if (myUserRole != (int)EnumUserRole.Waiter)
            {
                if (IsShiftStarted())
                {
                    var label = sender as Label;
                    UC_OrderCard clickedUserControl = FindParentUserControl(label);
                    if (clickedUserControl != null)
                    {
                        var aaa = (Order)clickedUserControl.Tag;

                        if (aaa.order_status == (int)EnumOrderStatus.NotPaid)
                        {
                            var orders = await new Order().SelectAllOrdersAndSubOrdersAsync(aaa.order_main);

                            var paymentForm = new FrmRestrauntPayment(orders);
                            if (paymentForm.ShowDialog() == DialogResult.OK)
                            {
                                UpdateSumma();
                                myOrders.Remove(aaa);
                                SetTableStatusFree(aaa);
                                clickedUserControl.InitAddButton();
                                if (paymentForm.checkPrint) Print(aaa);
                                Dialog.Info($"Оплата заказа с номером №{aaa.OrderNum} успешно завершено!");
                            }
                        }
                        else
                            Dialog.Error("Данная функция работает только для неоплаченныx заказов!");
                    }
                }

            }
        }

        private UC_OrderCard FindParentUserControl(Control control)
        {
            if (control == null)
                return null;

            // Проверяем, является ли текущий контрол UserControl
            if (control is UC_OrderCard userControl)
                return userControl;

            // Рекурсивно ищем родительский UserControl
            return FindParentUserControl(control.Parent);
        }

        private void BtnDozakaz(object sender, EventArgs e)
        {
            if (IsShiftStarted())
            {
                var panel = sender as FlowLayoutPanel;
                UC_OrderCard clickedUserControl = FindParentUserControl(panel);
                if (clickedUserControl != null)
                {
                    var aaa = (Order)clickedUserControl.Tag;

                    if (aaa.order_status == (int)EnumOrderStatus.NotPaid)
                    {
                        var window = new FrmCashe(aaa);
                        if (window.ShowDialog() == DialogResult.OK)
                        {
                            clickedUserControl.UpdateOrder(aaa);
                            UpdateSumma();
                        }
                    }
                    else
                        Dialog.Error("Данная функция работает только для неоплаченныx заказов!");
                }
            }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            if (IsShiftStarted())
            {
                ResetFilter();

                FrmOrderSelectTable frmOrderSelectTable = new FrmOrderSelectTable();
                if (frmOrderSelectTable.ShowDialog() == DialogResult.OK)
                {
                    if (sender is Guna2ImageButton clikedBtn)
                    {
                        Control parentPanel = clikedBtn.Parent;
                        var clickedCard = parentPanel.Parent as UC_OrderCard;
                        CreateOrderCard(clickedCard);
                    }
                }
            }
        }

        private async void CreateOrderCard(UC_OrderCard orderCard, Order order = null)
        {
            if (order == null)
                order = await new Order().OnSelectLastAsync();
            myOrders.Add(order);

            if (tableDict.TryGetValue(order.order_table, out var table))
            {
                order.tables = table;

                if (hallDict.TryGetValue(table.table_hall_id, out var hall))
                {
                    order.tables.hall = hall;
                }
            }
            if (userDict.TryGetValue(order.order_user, out var user))
            {
                order.user = user;
            }

            orderCard.InitOrder(order);
            orderCard.ContextMenuStrip = contextMenu;
            UpdateSumma();

            if (myOrders.Count >= itemsPerPage * totalPages)
            {
                AddExtraCards(myUserControls.Count);
            }
        }

        private async void MenuItemPay_Click(object sender, EventArgs e)
        {
            if (IsShiftStarted())
            {
                // Получаем пункт меню, который был нажат
                ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

                // Получаем контекстное меню, к которому принадлежит пункт меню
                ContextMenuStrip ownerMenu = menuItem.Owner as ContextMenuStrip;

                // Получаем UserControl, вызвавший контекстное меню
                UC_OrderCard clickedUserControl = ownerMenu.SourceControl as UC_OrderCard;

                var aaa = (Order)clickedUserControl.Tag;

                if (aaa.order_status == (int)EnumOrderStatus.NotPaid)
                {
                    var orders = await new Order().SelectAllOrdersAndSubOrdersAsync(aaa.order_main);

                    var paymentForm = new FrmRestrauntPayment(orders);
                    if (paymentForm.ShowDialog() == DialogResult.OK)
                    {
                        myOrders.Remove(aaa);
                        SetTableStatusFree(aaa);
                        clickedUserControl.InitAddButton();
                        if (paymentForm.checkPrint) Print(aaa);

                        Dialog.Info($"Оплата заказа с номером №{aaa.OrderNum} успешно завершено!");
                    }
                }
                else
                    Dialog.Error("Данная функция работает только для неоплаченныx заказов!");
            }
        }

        private async void SetTableStatusFree(Order aaa)
        {
            var orderTable = (await new Tables().OnLoadAsync()).Where(u => u.table_id == aaa.order_table).FirstOrDefault();
            orderTable.table_status = (int)EnumTablesStatus.Free;
            await orderTable.OnUpdateStatusAsync(orderTable);
        }

        private void MenuItemSubOrder_Click(object sender, EventArgs e)
        {
            if (Settings.Default.change_id != 0)
            {
                // Получаем пункт меню, который был нажат
                ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

                // Получаем контекстное меню, к которому принадлежит пункт меню
                ContextMenuStrip ownerMenu = menuItem.Owner as ContextMenuStrip;

                // Получаем UserControl, вызвавший контекстное меню
                UC_OrderCard clickedUserControl = ownerMenu.SourceControl as UC_OrderCard;

                var aaa = (Order)clickedUserControl.Tag;

                if (aaa.order_status == (int)EnumOrderStatus.NotPaid)
                {
                    var window = new FrmCashe(aaa);
                    if (window.ShowDialog() == DialogResult.OK)
                    {
                        clickedUserControl.UpdateOrder(aaa);
                    }
                }
                else
                    Dialog.Error("Данная функция работает только для неоплаченныx заказов!");
            }
        }

        private async void menuItemChangeTable_Click(object sender, EventArgs e)
        {
            if (IsShiftStarted())
            {
                // Получаем пункт меню, который был нажат
                ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

                // Получаем контекстное меню, к которому принадлежит пункт меню
                ContextMenuStrip ownerMenu = menuItem.Owner as ContextMenuStrip;

                // Получаем UserControl, вызвавший контекстное меню
                UC_OrderCard clickedUserControl = ownerMenu.SourceControl as UC_OrderCard;

                var aaa = (Order)clickedUserControl.Tag;

                if (aaa.order_status == (int)EnumOrderStatus.NotPaid)
                {
                    Tables dbTable = new Tables();
                    FrmTableChange frmTableSelect = new FrmTableChange();
                    if (frmTableSelect.ShowDialog() == DialogResult.OK)
                    {
                        var newTable = frmTableSelect.SelectedTable;
                        var lastTable = await dbTable.OnSelectTableAsync(aaa.order_table);

                        if (hallDict.TryGetValue(newTable.table_hall_id, out var newHall))
                        {
                            newTable.hall = newHall;
                        }

                        if (hallDict.TryGetValue(lastTable.table_hall_id, out var lastHall))
                        {
                            newTable.hall = lastHall;
                        }

                        if (newTable.hall.hall_type == (int)EnumHallType.Free &&
                            lastTable.hall.hall_type != (int)EnumHallType.Free)
                        {
                            Dialog.Error("Нельзя пересесть с платного столика на бесплатный!");
                            return;
                        }

                        lastTable.table_status = (int)EnumTablesStatus.Free;
                        await dbTable.OnUpdateStatusAsync(lastTable);

                        newTable.table_status = (int)EnumTablesStatus.Busy;
                        await dbTable.OnUpdateStatusAsync(newTable);

                        double sumDif = newTable.hall.hall_price - lastTable.hall.hall_price;

                        aaa.order_price += sumDif;
                        aaa.order_table = newTable.table_id;
                        await new Order().OnUpdateAsync(aaa);
                        clickedUserControl.UpdateOrder(aaa);
                        clickedUserControl.UpdateTable(newTable);
                    }
                }
                else
                    Dialog.Error("Данная функция работает только для неоплаченныx заказов!");
            }
        }

        private async void menuItemChangeOfficiant_Click(object sender, EventArgs e)
        {
            if (IsShiftStarted())
            {
                // Получаем пункт меню, который был нажат
                ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

                // Получаем контекстное меню, к которому принадлежит пункт меню
                ContextMenuStrip ownerMenu = menuItem.Owner as ContextMenuStrip;

                // Получаем UserControl, вызвавший контекстное меню
                UC_OrderCard clickedUserControl = ownerMenu.SourceControl as UC_OrderCard;

                var aaa = (Order)clickedUserControl.Tag;

                if (aaa.order_status == (int)EnumOrderStatus.NotPaid)
                {
                    FrmWaiterSelect frmWaiterSelect = new FrmWaiterSelect();
                    if (frmWaiterSelect.ShowDialog() == DialogResult.OK)
                    {
                        clickedUserControl.UpdateWaiter(frmWaiterSelect.SelectedWaiter.user_name);
                        aaa.order_user = frmWaiterSelect.SelectedWaiter.user_id;
                        await new Order().OnWaiterUpdateAsync(aaa);
                    }
                }
                else
                    Dialog.Error("Данная функция работает только для неоплаченныx заказов!");
            }
        }

        private void MenuItemPrint_Click(object sender, EventArgs e)
        {
            if (IsShiftStarted())
            {
                // Получаем пункт меню, который был нажат
                ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

                // Получаем контекстное меню, к которому принадлежит пункт меню
                ContextMenuStrip ownerMenu = menuItem.Owner as ContextMenuStrip;

                // Получаем UserControl, вызвавший контекстное меню
                UC_OrderCard clickedUserControl = ownerMenu.SourceControl as UC_OrderCard;

                var aaa = (Order)clickedUserControl.Tag;

                Print(aaa);
            }
        }

        private async void MenuItemCancel_Click(object sender, EventArgs e)
        {
            // Получаем пункт меню, который был нажат
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            // Получаем контекстное меню, к которому принадлежит пункт меню
            ContextMenuStrip ownerMenu = menuItem.Owner as ContextMenuStrip;

            // Получаем UserControl, вызвавший контекстное меню
            UC_OrderCard clickedUserControl = ownerMenu.SourceControl as UC_OrderCard;

            var aaa = (Order)clickedUserControl.Tag;

         //   OnPrintCancel(aaa);

            if (await new Order().OnDeleteOrderAsync(aaa.order_id))
            {
                await new OrderDetails().OnDeleteAsync(aaa.order_main, aaa.order_sub);
                myOrders.Remove(aaa);
                clickedUserControl.InitAddButton();
                var orderTable = await new Tables().OnSelectTableAsync(aaa.order_table);
                orderTable.table_status = (int)EnumTablesStatus.Free;
                await orderTable.OnUpdateStatusAsync(orderTable);
                Dialog.Info($"Заказ с номером {aaa.order_main} отменен успешно");
            }
        }

        //public void OnPrintCancel(Order myOrder)
        //{
        //    if (DataSQL.OnMyConfig().printer == "")
        //    {
        //        return;
        //    }

        //    try
        //    {
        //        Printer printer = new Printer(myOrder);

        //        var recordDoc = new PrintDocument
        //        {
        //            DocumentName = "Чек"
        //        };
        //        recordDoc.PrintPage += new PrintPageEventHandler(printer.PrintReceiptCancel);
        //        recordDoc.PrintController = new StandardPrintController();

        //        recordDoc.PrinterSettings.PrinterName = DataSQL.OnMyConfig().printer;

        //        if (recordDoc.PrinterSettings.IsValid)
        //        {
        //            recordDoc.Print();
        //            recordDoc.Dispose();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Dialog.Error(ex.Message);
        //    }
        //}

        private void Print(Order myOrder)
        {
            if (DataSQL.OnMyConfig().printerWaiter == "")
            {
                return;
            }

            if (myOrder != null)
            {

                Printer printer;

                printer = new Printer(myOrder);

                var recordDoc = new PrintDocument
                {
                    DocumentName = "Чек"
                };
                recordDoc.PrintPage += new PrintPageEventHandler(printer.RenderOrderReceiptCafe);
                recordDoc.PrintController = new StandardPrintController();

                recordDoc.PrinterSettings.PrinterName = DataSQL.OnMyConfig().printerWaiter;

                if (recordDoc.PrinterSettings.IsValid)
                {
                    recordDoc.Print();
                    recordDoc.Dispose();
                }
            }
        }

        private bool IsShiftStarted()
        {
            if (Settings.Default.change_id == 0)
            {
                Dialog.Error("Вы не начали смену!");
                return false;
            }
            return true;
        }

        private async void BtnSmenaBig_Click(object sender, EventArgs e)
        {
            var shiftForm = new UC_ShiftChange();
            await shiftForm.UpdateTextAsync();
            Globals.SetUserControl(shiftForm);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Globals.Exit();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private async void btnWithMySelf_Click(object sender, EventArgs e)
        {
            if (IsShiftStarted())
            {
                ResetFilter();
                Settings.Default.guest_count = 0;
                Settings.Default.Save();

                var hall = await new Hall().OnSelectHallAsync(WITH_MYSELF_INDEX);
                var tables = await new Tables().OnSelectTableAsync(WITH_MYSELF_INDEX);
                var window = new FrmCashe(null, hall, tables, (int)EnumOrderType.WithMySelf);
                if (window.ShowDialog() == DialogResult.OK)
                {
                    var emptyCard = myUserControls.FirstOrDefault(c => c.Tag == null);
                    CreateOrderCard(emptyCard);
                }
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            if (IsShiftStarted())
            {
                ResetFilter();
                Settings.Default.guest_count = 0;
                Settings.Default.Save();
                FrmDeliveryType deliveryForm = new FrmDeliveryType();
                if (deliveryForm.ShowDialog() == DialogResult.OK)
                {
                    var window = new FrmCashe(null, deliveryForm.selectedHall, deliveryForm.selectedTable, (int)EnumOrderType.Delivery);
                    if (window.ShowDialog() == DialogResult.OK)
                    {
                        var emptyCard = myUserControls.FirstOrDefault(c => c.Tag == null);
                        CreateOrderCard(emptyCard);
                    }
                }
                //var coordinator = new FrmOrderCoordinate((int)EnumOrderType.WithMySelf);
                //if (coordinator.ShowDialog() == DialogResult.OK)
                //{
                //    var emptyCard = myUserControls.FirstOrDefault(c => c.Tag == null);
                //    CreateOrderCard(emptyCard);
                //}
            }
        }

        private void btnCassa_Click(object sender, EventArgs e)
        {
            using (var window = new FrmCassa())
            {
                window.TableSelected += OnTableCassaSelect;
                window.ShowDialog();
            }
        }

        private void OnTableCassaSelect(object sender, TableEventArgs e)
        {
            var myTable = e.SelectedTable;
            if (myTable.table_status != (int)EnumTablesStatus.Free)
            {
                var ordersInTable = myOrders.Where(or => or.order_table == myTable.table_id).ToList();
                if (ordersInTable != null && ordersInTable.Count > 0)
                {
                    if (ordersInTable.Count == 1)
                    {
                        ProcessOrderPayment(ordersInTable[0], myTable);
                    }
                    else
                    {
                        FrmOrderSelect frmOrderSelect = new FrmOrderSelect(ordersInTable);
                        if (frmOrderSelect.ShowDialog() == DialogResult.OK)
                        {
                            ProcessOrderPayment(frmOrderSelect.selectedOrder, myTable, false);
                        }
                    }
                }

            }
            else
                Dialog.Error("Ошибка: Данный столик свободен и не имеет заказа");
        }

        private async void ProcessOrderPayment(Order order, Tables myTable, bool setTableFree = true)
        {
            var orders = await new Order().SelectAllOrdersAndSubOrdersAsync(order.order_main);

            var paymentForm = new FrmRestrauntPayment(orders);
            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                UpdateSumma();
                myOrders.Remove(order);

                if (setTableFree)
                {
                    myTable.table_status = (int)EnumTablesStatus.Free;
                    await myTable.OnUpdateStatusAsync(myTable);
                }

                //myUserControls.Where(uc => uc.myOrder.order_id == order.order_id).FirstOrDefault().InitAddButton();
                foreach (var orderCard in myUserControls)
                {
                    if (orderCard.Tag is Order orderInCard)
                    {
                        if (orderInCard.order_id == order.order_id)
                        {
                            orderCard.InitAddButton();
                        }
                    }
                }
                if (paymentForm.checkPrint) Print(order);
                Dialog.Info($"Оплата заказа с номером №{order.OrderNum} успешно завершено!");
            }
        }

        private void ResetFilter()
        {
            if (cmbUser.SelectedIndex != 0) cmbUser.SelectedIndex = 0;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages - 1)
            {
                currentPage++;
                ShowControlsOnPage(currentPage);
            }
            else
            {
                Dialog.Error("Вы в последной странице");
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                ShowControlsOnPage(currentPage);
            }
            else
            {
                Dialog.Error("Вы в первой странице");
            }
        }

        private void ShowControlsOnPage(int page)
        {
            UpdateNavigationDisplay(page);

            // Приостанавливаем обновление интерфейса
            tbl.SuspendLayout();

            tbl.Controls.Clear();

            int startIndex = page * itemsPerPage;
            int endIndex = Math.Min((page + 1) * itemsPerPage, myUserControls.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                tbl.Controls.Add(myUserControls[i]);
            }

            // Возобновляем обновление интерфейса
            tbl.ResumeLayout();
        }

        private void UpdateNavigationDisplay(int currentPage)
        {
            if (currentPage == 0 && totalPages > 1)
            {
                ShowNavigationButtons(true, false);
            }
            else if (currentPage == 0)
            {
                ShowNavigationButtons(false, false);
            }
            else if (currentPage == totalPages - 1)
            {
                ShowNavigationButtons(false, true);
            }
            else
            {
                ShowNavigationButtons(true, true);
            }
        }

        private void ShowNavigationButtons(bool showRight, bool showLeft)
        {
            pnlRight.Visible = showRight;
            pnlLeft.Visible = showLeft;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                btnPreviousPage.PerformClick();
                return true;
            }

            if (keyData == Keys.Right)
            {
                btnNextPage.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
