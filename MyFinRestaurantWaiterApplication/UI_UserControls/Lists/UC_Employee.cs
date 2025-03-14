using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;

namespace MyFinCassa.UC
{
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _ = UpdateGridAsync();
        }

        private async Task UpdateGridAsync()
        {
            var users = await new User().OnAllUserAsync();
            var roles = await new Role().OnLoadAsync();

            if (users == null || roles == null)
            {
                Dialog.Error("Ошибка загрузки данных.");
                dgvMain.DataSource = null;
                return;
            }

            var usersWithRoles = users.Select(u =>
            {
                u.role = roles.FirstOrDefault(r => r.role_id == u.user_role);
                return u;
            }).ToList();

            dgvMain.DataSource = new BindingSource { DataSource = usersWithRoles };
        }

    }
}

