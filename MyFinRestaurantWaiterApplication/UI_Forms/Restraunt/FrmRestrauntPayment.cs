using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MyFinCassa.Model;
using MyFinCassa.Helper;
using MyFinCassa.Properties;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmRestrauntPayment : Form
    {
        public bool isCardType = false;
        public bool checkPrint = false;
        private double orderTotalPrice;
        private double amount;
        private double waiterPercent;
        private double hallPrice;
        private string currency;

        private List<Order> ordersToPay;
        private Card selectedCard;
        private Order order;
        private Tables orderTable;
        private Hall orderHall;

        List<Product> allProducts = new List<Product>();
        private string currentInput = "0";

        public FrmRestrauntPayment(List<Order> orders)
        {
            InitializeComponent();

            InitForm(orders);
        }

        private async void InitForm(List<Order> orders)
        {
            order = orders[0];
            ordersToPay = orders;

            orderTable = await new Tables().OnSelectTableAsync(order.order_table);
            orderHall = await new Hall().OnSelectHallAsync(orderTable.table_hall_id);
            currency = await new Currency().OnGetCurrencyValueAsync();

            var userRole = Settings.Default.user_type;
            if (userRole != (int)EnumUserRole.Admin)
            {
                btnPay.Enabled = false;
            }


            InitProds();
            InitControls();
        }

        private async void InitProds()
        {
            var orDetails = await new OrderDetails().OnSelectAllOrderDetailsAsync(order.order_main);
            var prodTypes = await new Model.Type().OnLoadAsync();
            Product prod;

            foreach (var i in orDetails)
            {
                prod = await new Product().OnSelectAsync(i.details_prod);
                prod.type = prodTypes.Where(u => u.type_id == prod.prod_value).FirstOrDefault();
                prod.prod_total = i.details_count;
                prod.prod_status = i.details_status;
                OnAdd(prod);
            }

            UpdateProductsGrid();
        }

        private void OnAdd(Product aaa)
        {
            var check = false;

            foreach (var i in allProducts)
            {
                if (i.prod_id == aaa.prod_id)
                {
                    i.prod_total++;
                    check = true;
                    break;
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
                allProducts.Add(prod);
            }
        }

        private void UpdateProductsGrid()
        {
            dgvProduct.DataSource = allProducts;
            UpdateTextPrice();
        }

        private async void UpdateTextPrice()
        {
            var orderPrice = 0.0;
            var orderType = order.order_delivery;
            var myDiscount = order.order_discount;

            foreach (var i in allProducts)
                orderPrice += (i.prod_price * i.prod_total);

            if (myDiscount != 0)
                orderPrice -= myDiscount;
            var payment = await new Payment().OnLoadAsync();

            if (orderType == (int)EnumOrderType.Default)
            {
                if (payment.payment_type == (int)EnumCasheType.Fix)
                    waiterPercent = payment.payment_fix;
                else
                    waiterPercent = (orderPrice / 100 * payment.payment_percent);
            }

            orderTotalPrice = orderPrice + waiterPercent;

            if (orderHall.hall_type != (int)EnumHallType.TimeBased)
                hallPrice = orderHall.hall_price;
            else
                hallPrice = CalculateTimeBasedPrice(orderHall);

            orderTotalPrice += hallPrice;

            txtPercent.Text = $"Оплата официанту: {waiterPercent:N2} {currency}";
            txtPrice.Text = $"Стоимость заказа: {orderPrice:N2} {currency}";
            txtPriceHall.Text = $"Стоимость зала: {hallPrice:N2} {currency}";
            txtDiscount.Text = $"Скидка: {myDiscount:N2} {currency}";
            txtTotal.Text = $"Итого: {orderTotalPrice:N2} {currency}";
        }

        private async void InitControls()
        {
            var waiter = await new User().OnSelectUserAsync(order.order_user);
            var orderDate = DateTime.Parse(order.order_date);

            this.Text = $"Оплата заказа №{order.order_main}";
            txtDate.Text = $"Открыть: {orderDate.Hour}:{orderDate.Minute:D2}";
            txtWaiter.Text = $"Офиц: {waiter.user_name}";
            txtHall.Text = $"Зал: {orderHall.hall_name}";
            txtTable.Text = $"Стол: {orderTable.table_name}";

            txtCardGet.Text = "0,00";
            txtCashGet.Text = "0,00";
            txtSumma.Text = $"{orderTotalPrice:N2} {currency}";
            txtGet.Text = "0,00";
            btnCash.Checked = true; //new

            txtIn.Text = $"0,00 {currency}";
            txtZdacha.Text = $"0,00 {currency}";
            txtAmount.Text = $"0,00 {currency}";
        }

        private double CalculateTimeBasedPrice(Hall hall)
        {
            var now = DateTime.Now;
            if (DateTime.TryParse(order?.order_date, out var orderDate))
            {
                TimeSpan difference = now - orderDate;
                var minutesElapsed = difference.TotalMinutes;
                var minuteBonus = hall.hall_bonus;

                if (minutesElapsed > minuteBonus)
                {
                    return Math.Round(((minutesElapsed - minuteBonus) / 60) * hall.hall_price, 2);
                }
                return 0.0;

            }
            return 0.0;
        }

        private void TxtGet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cardGet = TryParse(txtCardGet.Text);
                var casheGet = TryParse(txtCashGet.Text);
                var totalGet = cardGet + casheGet;
                if (totalGet >= orderTotalPrice)
                {

                    txtZdacha.Text = $"{totalGet - orderTotalPrice:N2} {currency}";
                    txtAmount.Text = $"0,00 {currency}";
                }
                else
                {
                    txtAmount.Text = $"{orderTotalPrice - totalGet:N2} {currency}";
                    txtZdacha.Text = $"0,00 {currency}";
                }
                txtIn.Text = $"{totalGet:N2} {currency}";
            }
            catch (Exception)
            {
                //    Dialog.Error(ex.Message.ToString());
            }
        }

        private void OnFinishPay()
        {
            double cashMoney = Convert.ToDouble(txtCashGet.Text);
            UpdateCassaBalance(cashMoney);
            UpdateCardBalance();
            UpdateOrderPayments(DeterminePaymentType(cashMoney));
            UpdateOrderDetails();
            RemoveProduct();
            DialogResult = DialogResult.OK;
        }

        private async void UpdateOrderDetails()
        {
            var orDetails = await new OrderDetails().OnSelectAllOrderDetailsAsync(order.order_main);
            OrderDetails dbDetails = new OrderDetails();
            foreach (var detail in orDetails)
            {
                detail.details_status = (int)EnumDetailsStatus.Ready;
                await dbDetails.OnUpdateStatusAsync(detail);
            }
        }

        private async void UpdateCardBalance()
        {
            if (selectedCard != null)
            {
                selectedCard.card_balance += Convert.ToDouble(txtCardGet.Text);
                await new Card().OnUpdateAsync(selectedCard);
            }
        }

        private async void UpdateCassaBalance(double cashMoney)
        {
            var myCassa = await new Cassa().OnSelectCassaAsync(Settings.Default.mycassa_id);
            myCassa.cassa_money += cashMoney;
            await new Cassa().OnUpdateAsync(myCassa);
        }

        private EnumPaymentType DeterminePaymentType(double cashMoney)
        {
            if (selectedCard != null)
            {
                return cashMoney > 0 ? EnumPaymentType.Mixed : EnumPaymentType.Card;
            }
            return EnumPaymentType.Money;
        }

        private async void UpdateOrderPayments(EnumPaymentType payType)
        {
            Order dbOrder = new Order();
            foreach (var order in ordersToPay)
            {
                order.order_status = (int)EnumOrderStatus.Paid;
                order.order_payment = (int)payType;
                order.order_close_date = MyDate.DateFormat();
                order.order_price_hall = hallPrice;
                order.order_price = orderTotalPrice;
                order.print_status = 1;
                await dbOrder.OnUpdateAsync(order);
            }
        }

        //private void PayPercent()
        //{
        //    var user = new User().OnSelectUser(order.order_user);
        //    if (user.user_role == (int)EnumUserRole.Waiter && user.user_salary_type == (int)EnumSalaryType.No)
        //    {
        //        double waiterPercent = ordersToPay.Sum(or => or.order_price_waiter);
        //        user.user_balance += waiterPercent;
        //        new User().OnUpdate(user);
        //    }
        //}

        private async void RemoveProduct()
        {
            var stocks = await new Stock().OnLoadAsync();
            var dbStock = new Stock();
            //DetailsProductComplex complex = new DetailsProductComplex().OnLoadAllProds(order.order_main, true);
            foreach (var prod in allProducts)
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

        private void TxtGetSelect()
        {
            txtGet.Focus();
            txtGet.Select();
        }

        private void BtnCash_CheckedChanged(object sender, EventArgs e)
        {
            isCardType = !btnCash.Checked;
            txtGet.Text = btnCash.Checked ? txtCashGet.Text : txtCardGet.Text;
            btnCash.FillColor = btnCash.Checked ? Color.Goldenrod : Color.SteelBlue;
            btnCard.FillColor = btnCash.Checked ? Color.SteelBlue : Color.Goldenrod;
            pnlCashe.FillColor = btnCash.Checked ? Color.Goldenrod : Color.WhiteSmoke;
            pnlCard.FillColor = btnCash.Checked ? Color.WhiteSmoke : Color.Goldenrod;

            if (isCardType)
            {
                FrmCardType frmCardType = new FrmCardType();
                if (frmCardType.ShowDialog() == DialogResult.OK)
                {
                    selectedCard = frmCardType.SelectedCard;
                    txtCard.Text = $"Картой ({selectedCard.card_name}):";                //    MessageBox.Show("Selected card " + frmCardType.clickedCard.card_name);
                }
                else
                {
                    btnCash.Checked = true;
                    txtCard.Text = $"Картой:";
                }
            }
        }

        private void TxtGet_TextChanged_1(object sender, EventArgs e)
        {
            double value;
            value = TryParse(txtGet.Text);
            if (isCardType)
                txtCardGet.Text = value.ToString("N2");
            else
                txtCashGet.Text = value.ToString("N2");
        }

        private void BtnAmount_Click(object sender, EventArgs e)
        {
            double payed;
            if (isCardType)
                payed = TryParse(txtCashGet.Text);
            else
                payed = TryParse(txtCardGet.Text);

            amount = orderTotalPrice - payed;
            if (amount > 0)
                txtGet.Text = amount.ToString("N2");
        }

        private double TryParse(string str)
        {
            if (double.TryParse(str, out double result))
            {
                return result;
            }
            return 0;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (currentInput != "0")
            {
                currentInput += button.Text;
            }
            else
            {
                currentInput = button.Text;
            }
            UpdateLabel();
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            txtZdacha.Text = $"0,00 {currency}.";
            currentInput = "0";
            UpdateLabel();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                UpdateLabel();
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains(","))
            {
                currentInput += ",";
                UpdateLabel();
            }
        }

        private void AddAmount_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string input = button.Text;
            if (int.TryParse(input.Substring(1), out int number))
            {
                AddAmount(number);
            }
        }

        private void AddAmount(int amount)
        {
            var res = int.Parse(currentInput) + amount;
            currentInput = res.ToString();
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            if (string.IsNullOrEmpty(currentInput))
                currentInput = "0";
            txtGet.Text = currentInput;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                var cardGet = Convert.ToDouble(txtCardGet.Text);
                var casheGet = Convert.ToDouble(txtCashGet.Text);
                var totalGet = cardGet + casheGet;

                if (totalGet >= orderTotalPrice)
                {
                    checkPrint = false;
                    OnFinishPay();
                }
                else
                {
                    var ostatka = orderTotalPrice - totalGet;
                    AssignDebtToClient(ostatka);
                }
                //   Dialog.Error("Cумма меньше нужной!");
            }
            catch (Exception ex)
            {
                Dialog.Error(ex.Message.ToString());
            }
        }

        private void AssignDebtToClient(double summa)
        {
            string string_text = "Сумма недостаточна, готовы передать долг клиенту?";

            if (MessageBox.Show(
                string_text, "Долг",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DebtOperation debtOperation = new DebtOperation(summa);
                if (debtOperation.ShowDialog() == DialogResult.OK)
                {
                    OnFinishPay();
                }
            }
        }

        private void BtnPayWithCheck_Click(object sender, EventArgs e)
        {
            try
            {
                var cardGet = Convert.ToDouble(txtCardGet.Text);
                var casheGet = Convert.ToDouble(txtCashGet.Text);
                var totalGet = cardGet + casheGet;

                if (totalGet >= orderTotalPrice)
                {
                    checkPrint = true;
                    OnFinishPay();
                }
                else
                {
                    var ostatka = orderTotalPrice - totalGet;
                    AssignDebtToClient(ostatka);
                }
            }
            catch (Exception ex)
            {
                Dialog.Error(ex.Message.ToString());
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.D0 || keyData == Keys.NumPad0)
            {
                btn0.PerformClick();
                return true;
            }

            if (keyData == Keys.D1 || keyData == Keys.NumPad1)
            {
                btn1.PerformClick();
                return true;
            }

            if (keyData == Keys.D2 || keyData == Keys.NumPad2)
            {
                btn2.PerformClick();
                return true;
            }

            if (keyData == Keys.D3 || keyData == Keys.NumPad3)
            {
                btn3.PerformClick();
                return true;
            }

            if (keyData == Keys.D4 || keyData == Keys.NumPad4)
            {
                btnAdd3.PerformClick();
                return true;
            }

            if (keyData == Keys.D5 || keyData == Keys.NumPad5)
            {
                btn5.PerformClick();
                return true;
            }

            if (keyData == Keys.D6 || keyData == Keys.NumPad6)
            {
                btn6.PerformClick();
                return true;
            }

            if (keyData == Keys.D7 || keyData == Keys.NumPad7)
            {
                btn7.PerformClick();
                return true;
            }

            if (keyData == Keys.D8 || keyData == Keys.NumPad8)
            {
                btn8.PerformClick();
                return true;
            }

            if (keyData == Keys.D9 || keyData == Keys.NumPad9)
            {
                btn9.PerformClick();
                return true;
            }

            if (keyData == Keys.Oemcomma || keyData == Keys.OemPeriod)
            {
                btnDot.PerformClick();
                return true;
            }

            if (keyData == Keys.Back)
            {
                btnClear.PerformClick();
                return true;
            }

            if (keyData == Keys.Enter)
            {
                btnPay.PerformClick();
                return true;
            }

            if (keyData == Keys.Space)
            {
                btnPayWithCheck.PerformClick();
                return true;
            }

            if (keyData == Keys.T || keyData == Keys.N)
            {
                btnAmount.PerformClick();
                return true;
            }

            if (keyData == Keys.Left)
            {
                btnCard.PerformClick();
                return true;
            }

            if (keyData == Keys.Right)
            {
                btnCash.PerformClick();
                return true;
            }

            if (keyData == Keys.Tab)
            {
                if (btnCash.Checked) btnCard.PerformClick();
                else btnCash.PerformClick();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
