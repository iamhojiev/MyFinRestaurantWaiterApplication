using System;
using System.Linq;
using System.Data;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using MyFinCassa.Helper;
using MyFinCassa.Properties;
using MyFinCassa.Model;
using MyFinCassa.UI_UserControls.PageCashe;
using MyFinCassa.UI_Forms;
using MyFinCassa.UI_Forms.Cafe;
using System.Drawing;

namespace MyFinCassa.UC
{
    public partial class UC_PageCasheCafe : UserControl
    {
        // Модели
        private List<User> users;
        private List<Model.Type> prodTypes;
        private List<Product> products;
        private List<Tables> tables;
        private List<Hall> halls;

        // Заказ и оплата
        private Order myOrder;
        private double orderPrice = 0.0;
        private double myDiscount = 0.0;
        private string currency;
        private string orderComment;

        // Продукты
        private List<Product> basketProducts = new List<Product>();
        private Dictionary<string, List<Product>> productsByCategory;
        private Model.Type kgType;
        private List<UC_ProductWidget> productWidgets = new List<UC_ProductWidget>();

        // Действия и интерфейс
        private KeyboardForm keyboardForm;
        private Dictionary<string, Action<Product>> columnActions;

        // UI элементы
        private CategoryButton firstCategoryButton;
        private TableLayoutPanel currentTableLayoutPanel;
        private int currentRow;


        public UC_PageCasheCafe()
        {
            InitializeComponent();

            // Создаем новый объект шрифта с размером 12f
            var newFont = new Font(dgvProduct.ColumnHeadersDefaultCellStyle.Font.FontFamily, 12f);
            // Присваиваем новый объект шрифта свойству Font
            dgvProduct.ColumnHeadersDefaultCellStyle.Font = newFont;

            InitializeModels();
        }

        private async void InitializeModels()
        {
            users = await new User().OnAllUserAsync();
            products = await new Product().OnLoadAsync();
            prodTypes = await new Model.Type().OnLoadAsync();
            tables = await new Tables().OnLoadAsync();
            halls = await new Hall().OnLoadAllAsync();

            currency = await new Currency().OnGetCurrencyValueAsync();
            kgType = prodTypes.FirstOrDefault(t => t.type_name == "кг.");

            InitForm();
        }

        private async void InitForm()
        {
            var categories = await new Category().OnLoadAsync();

            foreach (var prod in products)
            {
                prod.category = categories.FirstOrDefault(u => u.category_id == prod.prod_category);
            }
            InitializeDictionary(products);
            InitializeWidgets();
            CreateCategoryButtons(categories);
            UpdateTextPrice();

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

            UpdateProductWidgets(productsFlowPanel);
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
                    product.type = prodTypes.FirstOrDefault(u => u.type_id == product.prod_value);
                    UC_ProductWidget productWidget = new UC_ProductWidget(product, currency, key);
                    productWidget.Container.Click += ProductWidget_Click;
                    productWidget.txtTitle.Click += ProductWidget_Click;
                    productWidget.txtProdPrice.Click += ProductWidget_Click;
                    productWidget.picProd.Click += ProductWidget_Click;
                    productWidgets.Add(productWidget);
                }
            }
        }

        private void UpdateProductWidgets(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is UC_ProductWidget productWidget)
                {
                    if (productWidget.Container.Tag is Product product)
                    {
                        var basketProduct = basketProducts.FirstOrDefault(p => p.prod_id == product.prod_id);
                        productWidget.UpdateSelection(basketProduct);
                    }
                }
                else if (control.HasChildren)
                {
                    UpdateProductWidgets(control);
                }
            }
        }

        private void ProductWidget_Click(object sender, EventArgs e)
        {
            if (((Control)sender).Tag is Product product)
            {
                product.prod_total = 0;
                OnAdd(product);
            }
        }

        private async void BtnPay_Click(object sender, EventArgs e)
        {
            if (!HasProductsInBasket())
                return;

            var paymentForm = new FrmCafePayment(basketProducts, GetOrderDiscount(), await GetOrderId());
            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                if (myOrder == null)
                {
                    var idForNewOrder = await GetCurrentOrderId();
                    await OnCreateDefaultOrderAsync(idForNewOrder, status: (int)EnumOrderStatus.Paid, payment: paymentForm.SelectedPaymentType, comment: orderComment);
                    await OnCreateOrderDetailsAsync(idForNewOrder);

                    if (paymentForm.PrintCheckFlag)
                    {
                        var lastOrder = await new Order().OnSelectLastAsync();
                        await InitializeOrder(lastOrder);
                        PrinterHelper.PrintOrderReceipt(lastOrder, true, paymentForm.TotalPaidAmount);
                    }

                    Dialog.Info("Оплата заказа прошла успешно.");
                }
                else
                {
                    myOrder.order_price = orderPrice;
                    myOrder.order_status = (int)EnumOrderStatus.Paid;
                    myOrder.order_payment = paymentForm.SelectedPaymentType;
                    myOrder.order_close_date = MyDate.DateFormat();

                    await new OrderDetails().OnDeleteAsync(myOrder.order_main, myOrder.order_sub);
                    await new Order().OnUpdateAsync(myOrder);
                    await OnCreateOrderDetailsAsync(myOrder.order_main);

                    if (paymentForm.PrintCheckFlag)
                    {
                        PrinterHelper.PrintOrderReceipt(myOrder, true, paymentForm.TotalPaidAmount);
                    }

                    Dialog.Info("Оплата заказа прошла успешно.");
                }
                await RemoveProductStocks(basketProducts);
                ResetForm();
            }
        }

        private async Task RemoveProductStocks(List<Product> products)
        {
            var stocks = await new Stock().OnLoadAsync();
            var dbStock = new Stock();
            //DetailsProductComplex complex = new DetailsProductComplex().OnLoadAllProds(order.order_main, true);
            foreach (var prod in products)
            {
                prod.recipe = await new Recipe().OnSelectAsync(prod.prod_id);

                foreach (var i in prod.recipe)
                {
                    i.stock = stocks.Where(u => u.stock_id == i.recipe_stock).FirstOrDefault();

                    i.stock.stock_count -= (i.recipe_count * prod.prod_total);

                    await dbStock.OnUpdateCountAsync(i.stock);
                }
            }
        }

        private double GetOrderDiscount()
        {
            if (double.TryParse(txtDiscount.Text, out var discount))
            {
                return discount;
            }
            else
            {
                return 0;
            }
        }

        private async Task<int> GetOrderId()
        {
            if (myOrder != null)
            {
                return myOrder.order_main;
            }
            else
            {
                return await GetCurrentOrderId();
            }
        }

        private async void BtnPending_Click(object sender, EventArgs e)
        {
            if (!HasProductsInBasket())
                return;

            if (myOrder == null)
            {
                var idForNewOrder = await GetCurrentOrderId();
                if (await OnCreateDefaultOrderAsync(idForNewOrder, status: (int)EnumOrderStatus.NotPaid, comment: orderComment))
                {
                    if (await OnCreateOrderDetailsAsync(idForNewOrder))
                    {
                        orderComment = string.Empty;
                        Dialog.Info("Заказ успешно оформлен и сохранён.");
                        ResetForm();
                    }
                }
            }
            else
            {
                myOrder.order_price = orderPrice;
                myOrder.order_discount = Convert.ToDouble(txtDiscount.Text);
                if (!string.IsNullOrEmpty(orderComment))
                {
                    myOrder.order_comment = orderComment;
                    orderComment = string.Empty;
                }
                await new Order().OnUpdateAsync(myOrder);
                await new OrderDetails().OnDeleteAsync(myOrder.order_main, myOrder.order_sub);

                if (await OnCreateOrderDetailsAsync(myOrder.order_main))
                {
                    Dialog.Info("Заказ успешно оформлен и сохранён.");
                    ResetForm();
                }
            }

        }

        private async Task<int> GetCurrentOrderId()
        {
            return await new Que().GetQueNumAsync();
        }

        private void ResetForm()
        {
            basketProducts.Clear();
            dgvProduct.DataSource = basketProducts;
            myOrder = null;
            txtDiscount.Text = "0";
            toggleComment.Checked = false;
            UpdateTextPrice();
            UpdateProductWidgets(productsFlowPanel);
        }

        private async Task<bool> OnCreateOrderDetailsAsync(int mainOrderId)
        {
            OrderDetails checkList;
            var dbDetails = new OrderDetails();
            foreach (var i in basketProducts)
            {
                checkList = new OrderDetails()
                {
                    details_order = mainOrderId,
                    details_prod = i.prod_id,
                    details_count = i.prod_total,
                    details_comment = i.prod_comment,
                    details_status = (int)EnumDetailsStatus.Ready,
                };
                await dbDetails.OnInsertAsync(checkList);
            }
            return true;
        }

        private async Task<bool> OnCreateDefaultOrderAsync(int orderMain, int status = 1, int payment = 1, string comment = "")
        {
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
            }

            var orders = new Order()
            {
                order_main = orderMain,
                order_user = Settings.Default.user_id,
                order_shift = Settings.Default.change_id,
                order_date = MyDate.DateFormat(),
                order_close_date = status == (int)EnumOrderStatus.Paid ? MyDate.DateFormat() : "",
                order_price = orderPrice,
                order_table = -100,
                order_delivery = (int)EnumOrderType.Default,
                order_payment = payment,
                order_status = status,
                order_status_cook = (int)EnumDetailsStatus.Ready,
                order_comment = comment,
                order_discount = Convert.ToDouble(txtDiscount.Text)
            };
            await new Que().IncrementAsync();

            return await new Order().OnInsertAsync(orders);
        }

        private async Task<bool> OnCreateDeliveryOrderAsync(int orderMain, Hall deliveryType, int payment, string comment = "")
        {
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
            }

            var orders = new Order()
            {
                order_main = orderMain,
                order_user = Settings.Default.user_id,
                order_shift = Settings.Default.change_id,
                order_date = MyDate.DateFormat(),
                order_close_date = MyDate.DateFormat(),
                order_price = orderPrice,
                order_table = deliveryType.hall_id,
                order_delivery = (int)EnumOrderType.Delivery,
                order_payment = payment,
                order_status = (int)EnumOrderStatus.Paid,
                order_discount = Convert.ToDouble(txtDiscount.Text),
                order_status_cook = (int)EnumDetailsStatus.Ready,
                order_comment = comment,
                order_price_hall = deliveryType.hall_price,
            };
            await new Que().IncrementAsync();

            return await new Order().OnInsertAsync(orders);
        }

        private void OnAdd(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            // Если продукт относится к типу "kg", запрашиваем объем через форму
            if (product.type.type_id == kgType.type_id)
            {
                using (var frmVolume = new FrmProdVolume())
                {
                    if (frmVolume.ShowDialog() == DialogResult.OK)
                    {
                        product.prod_total = frmVolume.Volume;
                    }
                    else
                    {
                        return; // Пользователь отменил ввод объема
                    }
                }
            }

            // Пытаемся найти продукт в корзине по prod_id
            var existingProduct = basketProducts.FirstOrDefault(p => p.prod_id == product.prod_id);
            if (existingProduct != null)
            {
                // Продукт найден – увеличиваем его количество
                existingProduct.prod_total++;
            }
            else
            {
                // Продукт не найден – добавляем новый, гарантируя, что количество не меньше 1
                var newProduct = new Product
                {
                    prod_id = product.prod_id,
                    prod_name = product.prod_name,
                    prod_start_price = product.prod_start_price,
                    prod_kitchen = product.prod_kitchen,
                    prod_category = product.prod_category,
                    prod_price = product.prod_price,
                    prod_value = product.prod_value,
                    type = product.type,
                    prod_status = product.prod_status,
                    prod_total = product.prod_total == 0 ? 1 : product.prod_total
                };

                basketProducts.Add(newProduct);
            }

            UpdateProductsGrid();
        }


        BindingSource productBS = new BindingSource();
        private void UpdateProductsGrid()
        {
            // Сохранение текущего положения прокрутки
            int firstDisplayedRowIndex = dgvProduct.FirstDisplayedScrollingRowIndex;
            int displayedRowCount = dgvProduct.DisplayedRowCount(false);

            productBS.Clear();
            foreach (var i in basketProducts)
                productBS.Add(i);
            dgvProduct.DataSource = productBS;

            // Восстановление положения прокрутки
            if (firstDisplayedRowIndex >= 0 && firstDisplayedRowIndex < dgvProduct.RowCount)
            {
                dgvProduct.FirstDisplayedScrollingRowIndex = firstDisplayedRowIndex;
                if (displayedRowCount > 0 && firstDisplayedRowIndex + displayedRowCount < dgvProduct.RowCount)
                {
                    dgvProduct.FirstDisplayedScrollingRowIndex = firstDisplayedRowIndex + displayedRowCount - 1;
                }
            }

            UpdateTextPrice();
            UpdateProductWidgets(productsFlowPanel);
        }


        private void SetProductsGrid(List<Product> products)
        {
            productBS.Clear();
            basketProducts = products;
            foreach (var i in basketProducts)
                productBS.Add(i);
            dgvProduct.DataSource = productBS;

            UpdateProductWidgets(productsFlowPanel);
            UpdateTextPrice();
        }

        private async Task UpdateOrderText()
        {
            var text = myOrder != null ? $"Заказ: {myOrder.order_main}" : $"Заказ: {await GetCurrentOrderId()}";
            txtOrderNum.Text = text;
        }

        private async void UpdateTextPrice()
        {
            orderPrice = 0.0;

            foreach (var i in basketProducts)
                orderPrice += (i.prod_price * i.prod_total);

            if (orderPrice > 0.0)
            {
                orderPrice -= myDiscount;
            }
            else
            {
                txtDiscount.Text = "0";
            }

            txtTotal.Text = $"Итого: {orderPrice:N2} {currency}";
            await UpdateOrderText();
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
                    foreach (var i in basketProducts)
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

        private void GridBtnAddOne_Click(Product product)
        {
            if (product.prod_status != (int)EnumDetailsStatus.Ready)
                OnAdd(product);
        }

        private void GridBtnMinusOne_Click(Product product)
        {
            foreach (var i in basketProducts)
            {
                if (i.prod_id == product.prod_id && i.prod_status != (int)EnumDetailsStatus.Ready)
                {
                    if (i.prod_total > 1)
                    {
                        PrintRemoval(i);
                        i.prod_total--;
                    }
                    else
                    {
                        basketProducts.Remove(i);
                    }
                    break;
                }
            }
            UpdateProductsGrid();
        }

        private void PrintRemoval(Product i)
        {
            if (myOrder != null)
            {
                PrinterHelper.PrintProductRemovalReceipt(myOrder, i);
            }
        }

        private void GridBtnRemoveAll_Click(Product product)
        {
            basketProducts.Remove(product);
            PrintRemoval(product);
            UpdateProductsGrid();
        }

        private async void BtnDelivery_Click(object sender, EventArgs e)
        {
            if (!HasProductsInBasket())
                return;

            var deliveryForm = new FrmDeliveryType();
            if (deliveryForm.ShowDialog() == DialogResult.OK)
            {
                var paymentForm = new FrmCafePayment(basketProducts, GetOrderDiscount(), await GetOrderId(), deliveryPrice: deliveryForm.selectedHall.hall_price);
                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    if (myOrder == null)
                    {
                        var idForNewOrder = await GetCurrentOrderId();
                        await OnCreateDeliveryOrderAsync(idForNewOrder, deliveryForm.selectedHall, payment: paymentForm.SelectedPaymentType, comment: orderComment);
                        await OnCreateOrderDetailsAsync(idForNewOrder);

                        if (paymentForm.PrintCheckFlag)
                        {
                            var lastOrder = await new Order().OnSelectLastAsync();
                            await InitializeOrder(lastOrder);
                            PrinterHelper.PrintOrderReceipt(lastOrder, true, paymentForm.TotalPaidAmount);
                        }

                        Dialog.Info("Оплата заказа прошла успешно.");
                    }
                    else
                    {
                        Dialog.Error("Доставка этого заказа невозможна, так как он находится в статусе 'отложен'");
                    }
                    await RemoveProductStocks(basketProducts);
                    ResetForm();
                }
            }
        }

        private bool HasProductsInBasket()
        {
            if (dgvProduct.Rows.Count == 0)
            {
                Dialog.Error("Необходимо выбрать хотя бы одно блюдо перед оформлением заказа.");
                return false;
            }
            return true;
        }


        private async Task InitializeOrder(Order order)
        {
            order.user = users.FirstOrDefault(u => u.user_id == order.order_user);
            order.tables = tables.FirstOrDefault(t => t.table_id == order.order_table);
            order.tables.hall = halls.FirstOrDefault(h => h.hall_id == order.tables.table_hall_id);

            var details = await new OrderDetails().OnSelectAllOrderDetailsAsync(order.order_main);
            foreach (var detail in details)
            {
                detail.product = products.FirstOrDefault(t => t.prod_id == detail.details_prod);
                detail.product.type = prodTypes.FirstOrDefault(t => t.type_id == detail.product.prod_value);
                detail.product.prod_total = detail.details_count;
            }
            order.orderDetails = details;
        }

        private void ToggleComment_CheckedChanged(object sender, EventArgs e)
        {
            toggleComment.CheckedChanged -= ToggleComment_CheckedChanged;
            if (toggleComment.Checked)
            {
                var commentForm = new FrmOrderComment(text: myOrder?.order_comment);
                if (commentForm.ShowDialog() == DialogResult.OK)
                {
                    orderComment = commentForm.CommentText;
                    if (commentForm.PendingClicked)
                    {
                        btnToPending.PerformClick();
                        toggleComment.Checked = false;
                    }
                }
            }
            else
            {
                orderComment = string.Empty;
            }
            toggleComment.CheckedChanged += ToggleComment_CheckedChanged;
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

            var columnName = dgvProduct.Columns[e.ColumnIndex].Name;

            if (e.RowIndex < 0 || e.RowIndex >= dgvProduct.Rows.Count || e.ColumnIndex < 0 || e.ColumnIndex >= dgvProduct.Columns.Count)
            {
                //MessageBox.Show("Некорректный индекс строки или столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(dgvProduct.SelectedRows[0].DataBoundItem is Product product))
            {
                // MessageBox.Show("Не удалось получить данные продукта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                Product foundProduct = basketProducts.Find(p => p.prod_id == product.prod_id);
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

        private void btnSaved_Click(object sender, EventArgs e)
        {
            FrmPendingOrders frmPendingOrders = new FrmPendingOrders();
            if (frmPendingOrders.ShowDialog() == DialogResult.OK)
            {
                myOrder = frmPendingOrders.SelectedOrder;
                txtDiscount.Text = myOrder.order_discount.ToString();
                SetProductsGrid(frmPendingOrders.SelectedOrderProducts);
            }
        }
        private void BtnClearBasket_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Вы уверены, что хотите полностью очистить корзину? Все продукты будут удалены.",
                "Подтверждение очистки корзины",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Если пользователь нажал "Да", очистить корзину
                ResetForm();
            }
        }
    }
}
