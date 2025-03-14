using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MyFinCassa.Helper;
using MyFinCassa.Properties;
using MyFinCassa.Model;
using System.Threading.Tasks;

namespace MyFinCassa.UI_Forms.Cafe
{
    public partial class FrmCafePayment : Form
    {

        public int paymentType;
        public bool isCardType = false;
        public bool checkPrint = false;

        private readonly double orderDiscount;
        private readonly double deliveryPrice;
        private double orderTotalPrice;
        private double amount;
        private string currency;
        private int orderId;

        private Card selectedCard;

        private string currentInput = "0,00";

        public FrmCafePayment(List<Product> products, double discount, int order, double deliveryPrice = 0)
        {
            InitializeComponent();

            this.deliveryPrice = deliveryPrice;
            orderDiscount = discount;
            orderId = order;
            InitForm(products);
            OnCasheClicked();
        }

        private async void InitForm(List<Product> products)
        {
            currency = await new Currency().OnGetCurrencyValueAsync();

            var userRole = Settings.Default.user_type;
            if (userRole != (int)EnumUserRole.Admin)
            {
                btnPay.Enabled = false;
            }

            InitControls();
            UpdateProductsGrid(products);
        }

        private void UpdateProductsGrid(List<Product> products)
        {
            dgvProduct.DataSource = products;
            UpdateTextPrice(products);
        }

        private void UpdateTextPrice(List<Product> products)
        {
            orderTotalPrice = 0.0;

            foreach (var i in products)
                orderTotalPrice += (i.prod_price * i.prod_total);

            txtPrice.Text = $"Стоимость заказа: {orderTotalPrice:N2}";

            if (orderDiscount != 0)
                orderTotalPrice -= orderDiscount;

            orderTotalPrice += deliveryPrice;

            txtDeliveryPrice.Text = $"Стоимость доставки: {deliveryPrice:N2}";
            txtDiscount.Text = $"Скидка: {orderDiscount:N1}";
            txtTotal.Text = $"Итого: {orderTotalPrice:N2}";
            txtSumma.Text = $"{orderTotalPrice:N2} {currency}";
        }

        private void InitControls()
        {
            txtCardGet.Text = "0,00";
            txtCashGet.Text = "0,00";
            txtGet.Text = "0,00";

            txtIn.Text = $"0,00 {currency}";
            txtZdacha.Text = $"0,00 {currency}";
            txtAmount.Text = $"0,00 {currency}";
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //    Dialog.Error(ex.Message.ToString());
            }
        }

        private async void OnFinishPay()
        {
            double cashMoney = Convert.ToDouble(txtCashGet.Text);
            double cardMoney = Convert.ToDouble(txtCardGet.Text);

            if (cashMoney > 0)
            {
                paymentType = (int)EnumPaymentType.Money;
            }
            else if (cardMoney > 0)
            {
                paymentType = (int)EnumPaymentType.Card;
            }
            else
            {
                paymentType = (int)EnumPaymentType.Mixed;
            }

            if (paymentType == (int)EnumPaymentType.Money)
            {
                await UpdateCassaBalance(cashMoney);
            }
            else if (paymentType == (int)EnumPaymentType.Card)
            {
                await UpdateCardBalance(cardMoney);
            }
            else if (paymentType == (int)EnumPaymentType.Mixed)
            {
                await UpdateCassaBalance(cashMoney);
                await UpdateCardBalance(cardMoney);
            }

            DialogResult = DialogResult.OK;
        }

        private async Task UpdateCardBalance(double cardMoney)
        {
            if (selectedCard != null && cardMoney > 0)
            {
                selectedCard.card_balance += cardMoney;
                await new Card().OnUpdateAsync(selectedCard);

                await BalanceSystem.Instance.AddCashOperation(EnumPaymentType.Card,cardMoney, orderId, selectedCard.card_id);
            }
        }

        private async Task UpdateCassaBalance(double cashMoney)
        {
            if (cashMoney > 0)
            {
                var myCassa = await new Cassa().OnSelectCassaAsync(Settings.Default.mycassa_id);
                myCassa.cassa_money += cashMoney;
                await new Cassa().OnUpdateAsync(myCassa);

                await BalanceSystem.Instance.AddCashOperation(EnumPaymentType.Money, cashMoney, orderId, myCassa.cassa_id);
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

        private void PnlCard_Click(object sender, EventArgs e)
        {
            isCardType = true;
            txtGet.Text = txtCardGet.Text;
            pnlCashe.FillColor = Color.WhiteSmoke;
            pnlCard.FillColor = Color.Goldenrod;

            FrmCardType frmCardType = new FrmCardType();
            if (frmCardType.ShowDialog() == DialogResult.OK) // esli karta vibrano
            {
                selectedCard = frmCardType.SelectedCard;
                txtCard.Text = $"Картой ({selectedCard.card_name}):";
                currentInput = txtCardGet.Text;
            }
            else
            {
                txtCard.Text = $"Картой:";
                OnCasheClicked();
            }
        }

        private void PnlCashe_Click(object sender, EventArgs e)
        {
            OnCasheClicked();
        }

        private void OnCasheClicked()
        {
            isCardType = false;
            txtGet.Text = txtCashGet.Text;
            currentInput = txtCashGet.Text;
            pnlCashe.FillColor = Color.Goldenrod;
            pnlCard.FillColor = Color.WhiteSmoke;
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
            {
                txtGet.Text = amount.ToString("N2");
                currentInput = amount.ToString("N2");
            }
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
            if (currentInput != "0" && !currentInput.Contains(",00"))
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
            currentInput = "0,00";
            UpdateLabel();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Ensure the input is not empty and not already '0'
            if (currentInput == "0,00" || currentInput == "0")
            {
                return;
            }

            // Handle cases where input ends with ",00"
            if (currentInput.EndsWith(",00"))
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 4);
            }
            else
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
            }

            // Update the label with the new input
            UpdateLabel();
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
            if (!int.TryParse(currentInput, out int currentValue))
            {
                currentValue = 0;
            }

            var res = currentValue + amount;
            currentInput = res.ToString();
            UpdateLabel();
        }


        private void UpdateLabel()
        {
            if (string.IsNullOrEmpty(currentInput))
                currentInput = "0,00";
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

            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}