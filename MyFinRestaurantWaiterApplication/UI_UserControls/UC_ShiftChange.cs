using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using MyFinCassa.Properties;

namespace MyFinCassa.UC
{
    public partial class UC_ShiftChange : UserControl
    {
        public UC_ShiftChange()
        {
            InitializeComponent();
        }

        private async void BtnChange_Click(object sender, EventArgs e)
        {
            int currentShiftId = Settings.Default.change_id;

            if (currentShiftId == 0) // Открываем смену
            {
                int userId = Settings.Default.user_id;
                if (userId == 0)
                {
                    Dialog.Error("Не удалось определить текущего пользователя.");
                    return;
                }

                var newShift = new Shift
                {
                    shift_date_open = MyDate.DateFormat(),
                    shift_user_id = userId,
                    shift_status = (int)EnumShift.Open,
                    shift_date_close = string.Empty
                };

                if (await new Shift().OnInsertAsync(newShift))
                {
                    var lastShift = await new Shift().OnSelectLastAsync();
                    if (lastShift != null)
                    {
                        Settings.Default.change_id = lastShift.shift_id;
                        Settings.Default.Save();
                    }
                    else
                    {
                        Dialog.Error("Ошибка при открытии смены: не удалось получить ID последней смены.");
                    }
                }
            }
            else // Закрываем смену
            {
                var shift = await new Shift().OnSelectAsync(currentShiftId);
                if (shift == null)
                {
                    Dialog.Error("Не удалось найти текущую смену.");
                    return;
                }

                shift.shift_date_close = MyDate.DateFormat();
                shift.shift_status = (int)EnumShift.Close;

                if (await new Shift().OnUpdateAsync(shift))
                {
                    await PayUserSalaryAsync(shift);
                    Settings.Default.change_id = 0;
                    Settings.Default.Save();
                }
                else
                {
                    Dialog.Error("Не удалось закрыть смену.");
                }
            }

            await UpdateTextAsync();
        }

        private async Task PayUserSalaryAsync(Shift shift)
        {
            var user = await new User().OnSelectUserAsync(Settings.Default.user_id);
            if (user == null)
            {
                Dialog.Error("Не удалось загрузить данные пользователя для расчёта зарплаты.");
                return;
            }

            switch (user.user_salary_type)
            {
                case (int)EnumSalaryType.Daily:
                    if (SalaryManager.CheckForDailyPayment(user))
                    {
                        string result = $"За смену №{shift.shift_id} ({shift.shift_date_open} - {shift.shift_date_close})";
                        await SalaryManager.GiveUserSalary(user, user.user_salary, result);
                    }
                    break;

                case (int)EnumSalaryType.Percent when user.user_role == (int)EnumUserRole.Waiter:
                    double percent = await shift.WaiterPercentInShiftAsync();
                    if (percent > 0)
                    {
                        string result = $"За смену №{shift.shift_id} ({shift.shift_date_open} - {shift.shift_date_close})";
                        await SalaryManager.GiveUserSalary(user, percent, result);
                    }
                    break;
            }
        }

        public async Task UpdateTextAsync()
        {
            int currentShiftId = Settings.Default.change_id;

            if (currentShiftId == 0) // Смена закрыта
            {
                btnChange.Text = "Открыть смену";
                txtInfoChange.Text = "Смена закрыта";
            }
            else // Смена открыта
            {
                var currentShift = await new Shift().OnSelectShiftOpenAsync(Settings.Default.user_id);
                if (currentShift == null)
                {
                    Settings.Default.change_id = 0;
                    Settings.Default.Save();
                    txtInfoChange.Text = "Смена закрыта";
                }
                else
                {
                    txtInfoChange.Text = $"Смена №{currentShift.shift_id} {currentShift.shift_date_open}";
                    btnChange.Text = "Закрыть смену";
                }
            }
        }
    }

}
