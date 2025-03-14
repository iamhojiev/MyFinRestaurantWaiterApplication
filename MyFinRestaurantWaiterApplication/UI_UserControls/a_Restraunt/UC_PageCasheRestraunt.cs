using MyFinCassa.UI_Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using System.Drawing.Printing;
using MyFinCassa.Database;
using MyFinCassa.Properties;
using MyFinCassa.UI_UserControls.PageCashe;
using Guna.UI2.WinForms;
using System.Threading.Tasks;

namespace MyFinCassa.UC
{
    public partial class UC_PageCasheRestraunt : UserControl
    {
        private Order myOrder;
        private FrmCashe casheForm;
        private KeyboardForm keyboardForm;
        private List<Product> allProducts = new List<Product>();
        private List<Product> uniqueProducts = new List<Product>();
        private List<Product> orderProducts = new List<Product>();
        private List<Model.Type> prodTypes = new List<Model.Type>();
        private Model.Type kgType;
        private Dictionary<string, Action<Product>> columnActions;
        private double orderPrice = 0.0;
        private double orderTotalPrice = 0.0;
        private double myDiscount = 0.0;
        private double waiterPercent = 0.0;
        private double hallPrice = 0.0;
        private List<Hall> halls;
        private Hall selectedHall;
        private Tables selectedTable;
        private int orderType = 1;
        private string currency;
        private string orderComment;
        //private bool isCardType;
        private BindingSource productBS = new BindingSource();
        private Dictionary<string, List<Product>> productsByCategory;
        private List<UC_ProductWidget> productWidgets = new List<UC_ProductWidget>();
        private bool subOrder;

        private CategoryButton firstCategoryButton;
        private TableLayoutPanel currentTableLayoutPanel;
        private int currentRow;

        public UC_PageCasheRestraunt(FrmCashe casheForm, Order or = null, Hall hall = null, Tables table = null, int delivery = (int)EnumOrderType.Default)
        {
            InitializeComponent();
            this.casheForm = casheForm;

            InitForm(or, hall, table, delivery);
        }

        private async void InitForm(Order or, Hall hall, Tables table, int delivery)
        {
            currency = await new Currency().OnGetCurrencyValueAsync();
            var btnProducts = await new Product().OnLoadAsync();
            prodTypes = await new Model.Type().OnLoadAsync();
            kgType = prodTypes.Where(t => t.type_name == "кг.").FirstOrDefault();
            var categories = await new Category().OnLoadAsync();

            foreach (var prod in btnProducts)
            {
                prod.category = categories.Where(u => u.category_id == prod.prod_category).FirstOrDefault();
            }
            InitializeDictionary(btnProducts);
            InitializeWidgets();
            CreateCategoryButtons(categories);

            halls = await new Hall().OnLoadAllAsync();
            //var tables = new Tables().OnLoad();
            if (or != null)
            {
                myOrder = or;
                btnPay.Visible = false;
                subOrder = true;

                selectedTable = await new Tables().OnSelectTableAsync(myOrder.order_table);
                selectedHall = halls.Where(u => u.hall_id == selectedTable.table_hall_id).FirstOrDefault();

                orderType = myOrder.order_delivery;

                txtDiscount.Text = myOrder.order_discount.ToString();
                pnlComment.Visible = false;

                ////// Danger 
                Product prod;
                var orDetails = await new OrderDetails().OnSelectAllOrderDetailsAsync(myOrder.order_main);

                foreach (var i in orDetails)
                {
                    prod = await new Product().OnSelectAsync(i.details_prod);
                    prod.type = prodTypes.Where(u => u.type_id == prod.prod_value).FirstOrDefault();
                    prod.prod_total = i.details_count;
                    prod.prod_status = i.details_status;
                    OnAdd(prod, true);
                }
                ////// Danger 
            }
            else
            {
                subOrder = false;
                pnlComment.Visible = true;
                btnCheck.Visible = false;
                selectedHall = hall;
                selectedTable = table;
                orderType = delivery;
            }

            if (delivery == (int)EnumOrderType.WithMySelf)
            {
                btnPay.Visible = true;
            }

            var userRole = Settings.Default.user_type;
            if (userRole == (int)EnumUserRole.Waiter)
            {
                btnPay.Visible = false;
            }

            var disCheck = Settings.Default.discount;
            if (!disCheck)
            {
                txtDiscount.Visible = false;
            }

            UpdateTextHall();
            timerInit.Start();
        }

        private void timerInit_Tick(object sender, EventArgs e)
        {
            timerInit.Stop();
            firstCategoryButton.Button.PerformClick();
        }

        private void CreateCategoryButtons(List<Category> categories)
        {
            for (int i = 0; i < categories.Count; i++)
            {
                CategoryButton categoryButton = new CategoryButton(categories[i]);
                categoryButton.Button.Click += CategoryButton_Click;
                if (i == 0)
                    firstCategoryButton = categoryButton;
                categoriesFlowPanel.Controls.Add(categoryButton);
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            string category = ((Control)sender).Tag as string;
            productsFlowPanel.Controls.Clear();
            currentTableLayoutPanel = null;
            foreach (var productWidget in productWidgets)
            {
                if (productWidget.Category == category)
                {
                    AddUserControl(productWidget);
                }
            }
            Button_CheckedChanged(sender);
        }

        private void CreateNewTableLayoutPanel()
        {
            var columnCount = Settings.Default.column_cards;
            currentTableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = columnCount,
                RowCount = 1,
                Dock = DockStyle.Top, // Устанавливаем Dock в Top
                AutoSize = false, // Отключаем AutoSize
                Width = productsFlowPanel.Width - 30, // Устанавливаем ширину равной ширине FlowLayoutPanel
                Height = 150,
                //BackColor = Color.Brown,
            };

            // Настройка столбцов для равного распределения
            for (int i = 0; i < currentTableLayoutPanel.ColumnCount; i++)
            {
                currentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnCount)); // Каждый столбец занимает 1/3 ширины
            }

            currentRow = 0;
            productsFlowPanel.Controls.Add(currentTableLayoutPanel);
        }

        private void AddUserControl(UC_ProductWidget productWidget)
        {
            if (currentRow >= Settings.Default.column_cards || currentTableLayoutPanel == null) // Если заполнены все ячейки текущего TableLayoutPanel
            {
                CreateNewTableLayoutPanel(); // Создаем новый TableLayoutPane
                //currentRow = 0; // Сбрасываем счетчик строк
            }
            productWidget.Dock = DockStyle.Fill;
            // Добавляем UserControl в текущий TableLayoutPanel
            currentTableLayoutPanel.Controls.Add(productWidget, currentRow, 0);
            currentRow++;
        }

        private void Button_CheckedChanged(object sender)
        {
            Guna2Button rb = sender as Guna2Button;

            // Если радиокнопка выбрана
            if (rb.Checked)
            {
                // Сбрасываем выбор других радиокнопок в других UserControl
                foreach (var control in categoriesFlowPanel.Controls)
                {
                    if (control is UserControl && control != rb.Parent)
                    {
                        foreach (var subcontrol in (control as UserControl).Controls)
                        {
                            if (subcontrol is Guna2Button)
                            {
                                (subcontrol as Guna2Button).Checked = false;
                            }
                        }
                    }
                }
            }
        }

        private void InitializeDictionary(List<Product> products)
        {
            productsByCategory = new Dictionary<string, List<Product>>();
            var groupedProducts = products.GroupBy(p => p.category.category_name);
            foreach (var group in groupedProducts)
            {
                productsByCategory.Add(group.Key, group.ToList());
            }
        }

        private void InitializeWidgets()
        {
            foreach (string key in productsByCategory.Keys)
            {
                var oneCategoryProducts = productsByCategory[key];

                foreach (var product in oneCategoryProducts)
                {
                    var prodValue = prodTypes.Where(u => u.type_id == product.prod_value).FirstOrDefault();
                    UC_ProductWidget productWidget = new UC_ProductWidget(product, prodValue.type_name, currency, key);
                    productWidget.Container.Click += ProductWidget_Click;
                    productWidget.txtTitle.Click += ProductWidget_Click;
                    productWidget.txtProdPrice.Click += ProductWidget_Click;
                    productWidget.picProd.Click += ProductWidget_Click;
                    productWidgets.Add(productWidget);
                }
            }
        }

        private void ProductWidget_Click(object sender, EventArgs e)
        {
            var product = ((Control)sender).Tag as Product;
            product.type = prodTypes.Where(u => u.type_id == product.prod_value).FirstOrDefault();
            OnAdd(product);
        }

        private async void BtnPay_Click(object sender, EventArgs e)
        {
            if (dgvProduct.Rows.Count > 0)
            {
                var idForNewOrder = await GetIdForNewOrder();
                if (await OnCreateOrderAsync(idForNewOrder, (int)EnumOrderStatus.Paid, (int)EnumDetailsStatus.Ready))
                {
                    if (await OnCreateOrderDetailsAsync(idForNewOrder, false))
                    {
                        var lastOrder = await new Order().OnSelectLastAsync();

                        var paymentForm = new FrmRestrauntPayment(new List<Order> { lastOrder });
                        if (paymentForm.ShowDialog() == DialogResult.OK)
                        {
                            OnFinishPay();

                            if (paymentForm.checkPrint)
                            {
                                StartPrint(true, Convert.ToDouble(paymentForm.txtGet.Text));
                            }
                            casheForm.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            await new Order().OnDeleteOrderAsync(lastOrder.order_id);
                            await new OrderDetails().OnDeleteAsync(lastOrder.order_main, lastOrder.order_sub);
                        }
                    }
                }
            }
            else
            {
                Dialog.Error("Необходимо выбрать хотя бы одно блюдо перед оформлением заказа.");
            }
        }

        private async void BtnNaGotovku_Click(object sender, EventArgs e)
        {
            var diffProducts = allProducts.Except(orderProducts, new ProductCompaper()).ToList();
            // Вычисляем разницу между prod_total
            if (subOrder)
            {
                for (int i = 0; i < diffProducts.Count; i++)
                {
                    var p1 = diffProducts[i];
                    for (int j = 0; j < orderProducts.Count; j++)
                    {
                        var p2 = orderProducts[j];
                        if (p2.prod_id == p1.prod_id &&
                            p2.prod_total != p1.prod_total)
                        {
                            var total = Math.Abs(p1.prod_total - p2.prod_total);
                            diffProducts[i].prod_status = (int)EnumDetailsStatus.NewOrder;
                            diffProducts[i].prod_total = total;

                            break;
                        }
                    }
                }
                uniqueProducts = diffProducts;
            }
            else
            {
                uniqueProducts = diffProducts;
            }

            Console.WriteLine(uniqueProducts);
            if (diffProducts.Count > 0)
            {
                if (!subOrder)
                {
                    var idForNewOrder = await GetIdForNewOrder();
                    if (await OnCreateOrderAsync(idForNewOrder, (int)EnumOrderStatus.NotPaid, (int)EnumDetailsStatus.NewOrder, orderComment))
                        await OnCreateOrderDetailsAsync(idForNewOrder, false);

                    selectedTable.table_status = (int)EnumTablesStatus.Busy;
                    await selectedTable.OnUpdateStatusAsync(selectedTable);
                }
                else
                {
                    if (await OnCreateSubOrderAsync((int)EnumOrderStatus.NotPaid, (int)EnumDetailsStatus.NewOrder, myOrder.order_main, orderComment))
                    {
                        await OnCreateOrderDetailsAsync(myOrder.order_main, true);
                    }
                }
                casheForm.DialogResult = DialogResult.OK;
            }
            else
                Dialog.Error("Необходимо выбрать хотя бы одно блюдо перед оформлением заказа.");
        }

        private async Task<int> GetIdForNewOrder()
        {
            return await new Que().GetQueNumAsync();
        }

        private async Task<bool> OnCreateSubOrderAsync(int status = 1, int status_cook = 1, int my_order_id = 1, string comment = "")
        {
            var nextSubIndex = (await new Order().OnSelectLastSubOrderAsync(my_order_id)).order_sub + 1;
            var subOrderPrice = orderTotalPrice - myOrder.order_price;
            var orders = new Order()
            {
                order_main = my_order_id,
                order_sub = nextSubIndex,
                order_user = Settings.Default.user_id,
                order_guest = 0,
                order_shift = Settings.Default.change_id,
                order_date = MyDate.DateFormat(),
                order_close_date = "",
                order_price = subOrderPrice,
                order_table = selectedTable.table_id,
                order_delivery = orderType,
                order_payment = 0,
                order_status = status,
                order_status_cook = status_cook,
                order_comment = comment,
                order_price_waiter = waiterPercent,
                order_price_hall = 0,
                order_discount = Convert.ToDouble(txtDiscount.Text)
            };

            return await new Order().OnInsertAsync(orders);
        }

        private async void OnFinishPay()
        {
            productBS.Clear();
            allProducts.Clear();
            dgvProduct.DataSource = productBS;
            selectedTable.table_status = (int)EnumTablesStatus.Free;
            await selectedTable.OnUpdateStatusAsync(selectedTable);
            UpdateTextPrice();
        }

        private async Task<bool> OnCreateOrderDetailsAsync(int mainOrderId, bool subOrder)
        {
            int myOrderSubIndex = subOrder ? (await new Order().OnSelectLastSubOrderAsync(mainOrderId)).order_sub : 0;
            var products = subOrder ? uniqueProducts : allProducts;
            OrderDetails checkList;
            var dbDetails = new OrderDetails();
            foreach (var i in products)
            {
                checkList = new OrderDetails()
                {
                    details_order = mainOrderId,
                    details_sub_order = myOrderSubIndex,
                    details_prod = i.prod_id,
                    details_count = i.prod_total,
                    details_comment = i.prod_comment,
                    details_status = i.prod_status
                };
                await dbDetails.OnInsertAsync(checkList);
            }
            return true;
        }

        private async Task<bool> OnCreateOrderAsync(int order_id, int status = 1, int status_cook = 1, string comment = "")
        {
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
            }
            var orders = new Order()
            {
                order_main = order_id,
                order_user = Settings.Default.user_id,
                order_guest = Settings.Default.guest_count,
                order_shift = Settings.Default.change_id,
                order_date = MyDate.DateFormat(),
                order_close_date = "",
                order_price = orderTotalPrice,
                order_table = selectedTable.table_id,
                order_delivery = orderType,
                order_payment = 0,
                order_status = status,
                order_status_cook = status_cook,
                order_comment = comment,
                order_price_waiter = waiterPercent,
                order_price_hall = hallPrice,
                order_discount = Convert.ToDouble(txtDiscount.Text)
            };
            await new Que().IncrementAsync();

            return await new Order().OnInsertAsync(orders);
        }

        private void OnAdd(Product aaa, bool flag = false)
        {
            var check = false;

            if (aaa.type.type_id == kgType.type_id && flag != true)
            {
                var frmVolume = new FrmProdVolume();
                if (frmVolume.ShowDialog() == DialogResult.OK)
                {
                    aaa.prod_total = frmVolume.Volume;
                    //flag = true;
                }
                else
                {
                    return;
                }
            }

            foreach (var i in allProducts)
            {
                if (i.prod_id == aaa.prod_id)
                {
                    if (flag) i.prod_total += aaa.prod_total;
                    else i.prod_total++;
                    check = true;
                    break;
                }
            }

            foreach (var i in orderProducts)
            {
                if (flag)
                {
                    if (i.prod_id == aaa.prod_id)
                    {
                        i.prod_total += aaa.prod_total;
                        break;
                    }
                }
            }

            if (!check)
            {
                var prod = new Product()
                {
                    prod_id = aaa.prod_id,
                    prod_name = aaa.prod_name,
                    prod_start_price = aaa.prod_start_price,
                    prod_kitchen = aaa.prod_kitchen,
                    prod_category = aaa.prod_category,
                    prod_price = aaa.prod_price,
                    prod_value = aaa.prod_value,
                    type = aaa.type,
                    prod_status = aaa.prod_status,
                    prod_total = aaa.prod_total == 0 ? 1 : aaa.prod_total
                };
                var prodCopy = new Product()
                {
                    prod_id = prod.prod_id,
                    prod_name = prod.prod_name,
                    prod_start_price = prod.prod_start_price,
                    prod_kitchen = prod.prod_kitchen,
                    prod_category = prod.prod_category,
                    prod_price = prod.prod_price,
                    prod_value = prod.prod_value,
                    type = prod.type,
                    prod_status = prod.prod_status,
                    prod_total = prod.prod_total
                };

                if (flag)
                    orderProducts.Add(prodCopy);
                allProducts.Add(prod);
            }

            UpdateProductsGrid();
        }

        private void UpdateProductsGrid()
        {
            productBS.Clear();
            foreach (var i in allProducts)
                productBS.Add(i);
            dgvProduct.DataSource = productBS;
            UpdateTextPrice();
        }

        bool hallPriceCalculated = false;
        Payment payment;
        private async void UpdateTextPrice()
        {
            if (payment == null)
                payment = await new Payment().OnLoadAsync();

            orderPrice = 0.0;
            waiterPercent = 0.0;

            foreach (var i in allProducts)
                orderPrice += (i.prod_price * i.prod_total);

            if (myDiscount != 0)
                orderPrice -= myDiscount;

            if (orderType == (int)EnumOrderType.Default)
            {
                if (payment.payment_type == (int)EnumCasheType.Fix)
                    waiterPercent = payment.payment_fix;
                else
                    waiterPercent = (orderPrice / 100 * payment.payment_percent);
            }

            orderTotalPrice = orderPrice + waiterPercent;

            if (!hallPriceCalculated)
            {
                if (selectedHall.hall_type != (int)EnumHallType.TimeBased)
                    hallPrice = selectedHall.hall_price;
                else
                    hallPrice = CalculateTimeBasedPrice();
                hallPriceCalculated = true;
            }

            orderTotalPrice += hallPrice;

            txtPercent.Text = $"Оплата официанту: {waiterPercent:N2} {currency}";
            txtPrice.Text = $"Стоимость заказа: {orderPrice:N2} {currency}";
            txtTotal.Text = $"Итого: {orderTotalPrice:N2} {currency}";
        }

        private double CalculateTimeBasedPrice()
        {
            var now = DateTime.Now;
            if (DateTime.TryParse(myOrder?.order_date, out var orderDate))
            {
                TimeSpan difference = now - orderDate;
                var minutesElapsed = difference.TotalMinutes;
                var minuteBonus = selectedHall.hall_bonus;

                if (minutesElapsed > minuteBonus)
                {
                    return Math.Round(((minutesElapsed - minuteBonus) / 60) * selectedHall.hall_price, 2);
                }
                return 0.0;

            }
            return 0.0;
        }

        private void TxtDiscont_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
                myDiscount = 0;
            }
            else
            {
                if (double.TryParse(txtDiscount.Text, out double discount))
                {
                    var orderTotalPrice = 0.0;
                    foreach (var i in allProducts)
                        orderTotalPrice += (i.prod_price * i.prod_total);

                    if (discount > orderTotalPrice)
                        discount = orderTotalPrice;

                    txtDiscount.Text = discount.ToString();
                    myDiscount = discount;
                }
            }
            txtDiscount.SelectionStart = txtDiscount.Text.Length;
            UpdateTextPrice();
        }

        private void UpdateTextHall()
        {
            switch (orderType)
            {
                case (int)EnumOrderType.Default:
                    UpdateDefaultOrderType();
                    break;
                case (int)EnumOrderType.Delivery:
                    txtPriceHall.Text = $"Стоимость доставки: {selectedHall.hall_price} {currency}";
                    break;
                case (int)EnumOrderType.WithMySelf:
                    txtPriceHall.Text = "Самовызов бесплатен";
                    break;
                default:
                    break;
            }

            UpdateTextPrice();
        }

        private void UpdateDefaultOrderType()
        {
            if (selectedHall.hall_type != (int)EnumHallType.TimeBased)
            {
                txtPriceHall.Text = $"Стоимость зала: {selectedHall.hall_price} {currency}";
            }
            else
            {
                if (myOrder != null)
                {
                    UpdateTimeBasedPrice();
                }
                else
                {
                    txtPriceHall.Text = $"Стоимость зала: 0 {currency}";
                }
            }
        }

        private void UpdateTimeBasedPrice()
        {
            var now = DateTime.Now;
            if (DateTime.TryParse(myOrder.order_date, out var orderDate))
            {
                TimeSpan difference = now - orderDate;
                var minutesElapsed = difference.TotalMinutes;
                var minuteBonus = selectedHall.hall_bonus;

                if (minutesElapsed > minuteBonus)
                {
                    var hallPrice = Math.Round(((minutesElapsed - minuteBonus) / 60) * selectedHall.hall_price, 2);
                    txtPriceHall.Text = $"Стоимость зала: {hallPrice:N2} {currency} \n({difference.Hours:D2}ч:{difference.Minutes:D2}м)";
                }
                else
                {
                    txtPriceHall.Text = $"Стоимость зала: 0 {currency} ({difference.Hours:D2}ч:{difference.Minutes:D2}м)";
                }
            }
        }

        private void GridBtnAddOne_Click(Product product)
        {
            if (product.prod_status != (int)EnumDetailsStatus.Ready)
                OnAdd(product);
        }

        private void GridBtnMinusOne_Click(Product product)
        {
            foreach (var i in allProducts)
            {
                if (i.prod_id == product.prod_id && i.prod_status != (int)EnumDetailsStatus.Ready)
                {
                    if (i.prod_total > 1)
                    {
                        i.prod_total--;
                        PrintRemoveProduct(i);
                    }
                    else
                        allProducts.Remove(i);
                    break;
                }
            }
            UpdateProductsGrid();
        }

        private void GridBtnRemoveAll_Click(Product product)
        {
            if (product.prod_status != (int)EnumDetailsStatus.Ready)
            {
                allProducts.Remove(product);
                PrintRemoveProduct(product);
                UpdateProductsGrid();
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (myOrder != null)
                StartPrint();
        }

        private void PrintRemoveProduct(Product product)
        {
            if (DataSQL.OnMyConfig().printerWaiter == "")
            {
                return;
            }

            if (myOrder != null)
            {

                Printer printer;

                printer = new Printer(myOrder, product);

                var recordDoc = new PrintDocument
                {
                    DocumentName = "Чек"
                };
                recordDoc.PrintPage += new PrintPageEventHandler(printer.PrintReceiptRemove);
                recordDoc.PrintController = new StandardPrintController();

                recordDoc.PrinterSettings.PrinterName = DataSQL.OnMyConfig().printerWaiter;

                if (recordDoc.PrinterSettings.IsValid)
                {
                    recordDoc.Print();
                    recordDoc.Dispose();
                }
            }
        }

        public async void StartPrint(bool type = false, double price = 0.0)
        {
            if (DataSQL.OnMyConfig().printer == "")
            {
                return;
            }

            Printer printer;

            if (myOrder == null)
                myOrder = await new Order().OnSelectLastAsync();

            if (type)
                printer = new Printer(myOrder, true, price);
            else
                printer = new Printer(myOrder);

            var recordDoc = new PrintDocument
            {
                DocumentName = "Чек"
            };
            recordDoc.PrintPage += new PrintPageEventHandler(printer.PrintReceiptPage);
            recordDoc.PrintController = new StandardPrintController();

            recordDoc.PrinterSettings.PrinterName = DataSQL.OnMyConfig().printer;

            if (recordDoc.PrinterSettings.IsValid)
            {
                recordDoc.Print();
                recordDoc.Dispose();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            casheForm.Close();
        }

        private void ToggleComment_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleComment.Checked)
            {
                var commentForm = new FrmOrderComment();
                if (commentForm.ShowDialog() == DialogResult.OK)
                {
                    orderComment = commentForm.CommentText;
                    if (commentForm.PendingClicked)
                    {
                        btnNaGotovku.PerformClick();
                    }
                }
                else
                {
                    toggleComment.Checked = false;
                }
            }
            else
            {
                orderComment = string.Empty;
            }
        }

        private void DgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (columnActions == null || columnActions.Count == 0)
            {
                columnActions = new Dictionary<string, Action<Product>>
                {
                    { "GridBtnAddOne", GridBtnAddOne_Click },
                    { "GridBtnMinusOne", GridBtnMinusOne_Click },
                    { "GridBtnRemoveAll", GridBtnRemoveAll_Click }
                };
            }

            var product = (Product)dgvProduct.SelectedRows[0].DataBoundItem;
            var columnName = dgvProduct.Columns[e.ColumnIndex].Name;

            // Вызов соответствующего метода из словаря
            if (columnActions.TryGetValue(columnName, out Action<Product> action))
            {
                action(product);
            }
        }

        private void DgvProduct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var columnName = dgvProduct.Columns[e.ColumnIndex].Name;

            // Если двойной клик был не по кнопкам, обрабатываем продукт
            if (!columnActions.ContainsKey(columnName))
            {
                var product = (Product)dgvProduct.SelectedRows[0].DataBoundItem;
                Product foundProduct = allProducts.Find(p => p.prod_id == product.prod_id);
                if (foundProduct != null)
                {
                    var commentForm = new FrmOrderComment(foundProduct);
                    if (commentForm.ShowDialog() == DialogResult.OK)
                    {
                        foundProduct.prod_comment = commentForm.CommentText;
                    }
                }
            }
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            ShowKeyboard();
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            HideKeyboard();
        }

        private void ShowKeyboard()
        {
            keyboardForm = KeyboardManager.ShowNumpad();
            keyboardForm.KeyPressed += KeyPressedHandler;
        }

        private void HideKeyboard()
        {
            keyboardForm.KeyPressed -= KeyPressedHandler;
            KeyboardManager.HideKeyboard();
        }

        bool isFirstInput = true;
        private void KeyPressedHandler(string key)
        {
            if (isFirstInput)
            {
                txtDiscount.Text = key;
                isFirstInput = false;
                return;
            }
            if (key.Length == 1)
                txtDiscount.AppendText(key);
            else if (key == "<-")
            {
                if (txtDiscount.Text.Length > 0)
                    txtDiscount.Text = txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 1);
            }
        }
    }
}
