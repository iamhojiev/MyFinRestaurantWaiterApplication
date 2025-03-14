using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using MyFinCassa.Properties;
using MyFinCassa.UI_Forms;

namespace MyFinCassa.UC
{
    public partial class UC_Discount : UserControl
    {
        public UC_Discount()
        {
            InitializeComponent();
            InitFormAsync().ConfigureAwait(false);
        }

        private async Task InitFormAsync()
        {
            CheckDiscount();
            await CheckTableAsync();
            await CheckPrintAsync();

            txtColumnCount.Text = Settings.Default.column_cards.ToString();
            txtColumnCount.TextChanged += TxtColumnCount_TextChanged;

            tsDiscount.CheckedChanged += TsDiscount_CheckedChanged;
            tsPrint.CheckedChanged += TsPrint_CheckedChanged;
            tsTableDivide.CheckedChanged += TsTableDivide_CheckedChanged;
        }

        private void UpdateTextLabel(Label txtLabel, string label, bool isChecked)
        {
            txtLabel.Text = $"{label}: {(isChecked ? "вкл" : "выкл")}";
        }

        private async Task MakeLogAsync(string label, bool isChecked)
        {
            string status = isChecked ? "вкл" : "выкл";
            string message = $"Изменил настройку кассы: {label}: {status}";
            await Debug.DebugInsertAsync(message, Settings.Default.user_id);
        }

        private async Task CheckPrintAsync()
        {
            try
            {
                var myUser = await new User().OnSelectUserAsync(Settings.Default.user_id);
                if (myUser != null)
                {
                    bool isAdminOrManager = myUser.user_role == (int)EnumUserRole.Admin ||
                                       myUser.user_role == (int)EnumUserRole.Manager;

                    if (isAdminOrManager)
                    {
                        var printCheck = await new CassaSettings().IsPrinterCookingOutputAsync();
                        tsPrint.Checked = printCheck;
                        UpdateTextLabel(txtPrint, "Печать", printCheck);
                    }
                    else
                    {
                        DisablePrintOption();
                    }
                }
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при проверке печати: {ex.Message}");
            }
        }

        private void DisablePrintOption()
        {
            tsPrint.Checked = false;
            tsPrint.Enabled = false;
            txtPrint.Text = "Печать: (Недоступно)";
        }

        private void CheckDiscount()
        {
            bool discountEnabled = Settings.Default.discount;
            tsDiscount.Checked = discountEnabled;
            UpdateTextLabel(txtDiscountTitle, "Скидка", discountEnabled);
        }

        private async Task CheckTableAsync()
        {
            try
            {
                bool tableCheck = await new CassaSettings().IsTablesDivisibleAsync();
                tsTableDivide.Checked = tableCheck;
                UpdateTextLabel(txtDivideTable, "Разделить стол", tableCheck);
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при проверке настройки разделения столов: {ex.Message}");
            }
        }

        private async void TsDiscount_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextLabel(txtDiscountTitle, "Скидка", tsDiscount.Checked);
            await MakeLogAsync("Скидка", tsDiscount.Checked);

            Settings.Default.discount = tsDiscount.Checked;
            Settings.Default.Save();
        }

        private async void TsPrint_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int status = tsPrint.Checked ? 1 : 0;
                UpdateTextLabel(txtPrint, "Печать", tsPrint.Checked);
                await MakeLogAsync("Печать", tsPrint.Checked);
                PrintFormMatcher(tsPrint.Checked);

                await new CassaSettings().OnUpdatePrinterSettingsAsync(status);
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при обновлении настройки печати: {ex.Message}");
            }
        }

        private async void TsTableDivide_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int status = tsTableDivide.Checked ? 1 : 0;
                UpdateTextLabel(txtDivideTable, "Разделить стол", tsTableDivide.Checked);
                await MakeLogAsync("Разделить стол", tsTableDivide.Checked);

                await new CassaSettings().OnUpdateTableDivideAsync(status);
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при обновлении настройки разделения столов: {ex.Message}");
            }
        }

        private void PrintFormMatcher(bool printCheck)
        {
            if (printCheck)
            {
                var printCoordinator = new PrintCoordinator
                {
                    Name = "PrintForm"
                };
                printCoordinator.Show();
            }
            else
            {
                var printForm = Application.OpenForms["PrintForm"] as PrintCoordinator;
                printForm?.Dispose();
            }
        }

        private void TxtColumnCount_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is Guna2TextBox textBox) || string.IsNullOrEmpty(textBox.Text)) return;

            if (int.TryParse(textBox.Text, out int columnCount))
            {
                Settings.Default.column_cards = columnCount;
                Settings.Default.Save();
            }
            else
            {
                Dialog.Error("Введите корректное число для количества колонок.");
            }
        }
    }
}
