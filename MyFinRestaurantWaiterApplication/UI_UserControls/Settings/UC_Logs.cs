using System.Data;
using System.Linq;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;

namespace MyFinCassa.UC
{
    public partial class UC_Logs : UserControl
    {
        public UC_Logs()
        {
            InitializeComponent();
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            UpdateGrid();
        }

        public async void UpdateGrid()
        {
            var bs = new BindingSource();
            var user = new User();
            var debug = new Debug();

            var users = await user.OnAllUserAsync();
            var logs = await debug.OnLoadAsync();

            if (users == null || logs == null)
            {
                Dialog.Error("Ошибка загрузки данных пользователей или логов.");
                return;
            }

            var logWithUsers = logs.Select(log =>
            {
                log.user = users.FirstOrDefault(u => u.user_id == log.debug_admin);
                return log;
            }).ToList();

            bs.DataSource = logWithUsers;
            dgvMain.DataSource = bs;
        }
    }
}
