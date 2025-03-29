using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using MyFinCassa.Properties;
using MyFinCassa.UI_Forms;

namespace MyFinCassa.UC
{
    public partial class UC_CassaInfo : UserControl
    {
        private User myUser;
        private Cassa myCassa;

        public UC_CassaInfo()
        {
            InitializeComponent();
            InitializeDataAsync();
        }

        private async void InitializeDataAsync()
        {
            await UserInitAsync();
            await UpdateTextsAsync();
        }

        private async Task UserInitAsync()
        {
            myUser = await new User().OnSelectUserAsync(Settings.Default.user_id);
        }

        public async Task UpdateTextsAsync()
        {
            var currency = await new Currency().OnGetCurrencyValueAsync();
            myCassa = await new Cassa().OnSelectCassaAsync(Settings.Default.mycassa_id);

            txtCashCassa.Text = $"Наличные деньги: {myCassa.cassa_money:N2} {currency}";

            var cards = await new Card().OnLoadAsync();
            var cardsBalance = cards?.Sum(card => card.card_balance) ?? 0;
            txtCashMoney.Text = $"Безналичные деньги: {cardsBalance:N2} {currency}";

            txtPrice.Text = rbtGet.Checked ? myCassa.cassa_money.ToString("N2") : "0";
            rbtGet.Checked = true;
        }

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsUserAuthorized()) return;

                if (!double.TryParse(txtPrice.Text, out double transactionAmount) || transactionAmount <= 0)
                {
                    Dialog.Error("Введите корректную сумму для операции!");
                    return;
                }

                bool isDeposit = rbtPut.Checked;
                if (!await ProcessTransactionAsync(transactionAmount, isDeposit)) return;

                ClearInputFields();
                await UpdateTextsAsync();
                Dialog.Info("Баланс кассы успешно изменен!");
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при выполнении операции: {ex.Message}");
            }
        }

        private bool IsUserAuthorized()
        {
            if (myUser.user_role != (int)EnumUserRole.Admin)
            {
                Dialog.Error("Недостаточно прав доступа!");
                return false;
            }
            return true;
        }

        private async Task<bool> ProcessTransactionAsync(double transactionAmount, bool isDeposit)
        {
            double cassaBalance = myCassa.cassa_money;
            string comment = txtComment.Text.Trim();

            if (isDeposit)
            {
                cassaBalance += transactionAmount;
                await BalanceSystem.Instance.AddCassaOperation(EnumCassaOperationType.Пополнение, transactionAmount, myCassa.cassa_id, description: comment);
            }
            else
            {
                if (transactionAmount > cassaBalance)
                {
                    Dialog.Error("В кассе недостаточно денег!");
                    return false;
                }
                cassaBalance -= transactionAmount;
                await BalanceSystem.Instance.AddCassaOperation(EnumCassaOperationType.Снятие, transactionAmount, myCassa.cassa_id, description: comment);
            }

            myCassa.cassa_money = cassaBalance;

            await new Cassa().OnUpdateAsync(myCassa);
            return true;
        }

        private void ClearInputFields()
        {
            txtComment.Text = "";
            txtPrice.Text = "";
        }

        private void MoneyTypeChange_CheckedChanged(object sender, EventArgs e)
        {
            if (myCassa != null)
            {
                txtPrice.Text = rbtGet.Checked ? myCassa.cassa_money.ToString("N2") : "0";
                txtPrice.SelectAll();
                txtPrice.Focus();
            }
        }

        private void btnCardsInfo_Click(object sender, EventArgs e)
        {
            using (var cardsForm = new FrmCardType())
            {
                cardsForm.ShowDialog();
            }
        }
    }
}
