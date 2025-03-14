using MyFinCassa.Helper;
using System;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public static class SalaryManager
    {
        public static bool CheckForDailyPayment(User user)
        {
            // Проверяем, прошел ли месяц с последней выплаты
            if (DateTime.TryParse(user.user_last_payment, out DateTime lastPaymentDate))
            {
                if ((DateTime.Now - lastPaymentDate).Days >= 1)
                {
                    return true;
                }
            }
            return false;
        }

        public static async Task GiveUserSalary(User user, double amount, string description)
        {
            user.user_earnings += amount;
            user.user_last_payment = DateTime.Now.ToShortDateString();
            await new User().OnUpdateAsync(user);

            await CreateSalaryLog(user.user_id, amount, description);
        }

        private static async Task CreateSalaryLog(int userId, double amount, string description)
        {
            // Создание новой записи лога
            await BalanceSystem.Instance.AddSalaryOperation(EnumSalaryLogType.Начисление, amount, userId, description);
        }
    }
}
