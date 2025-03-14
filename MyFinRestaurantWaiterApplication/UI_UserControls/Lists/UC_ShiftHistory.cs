using MyFinCassa.UI_Forms;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MyFinCassa.Properties;
using MyFinCassa.Model;
using System.Threading.Tasks;

namespace MyFinCassa.UC
{
    public partial class UC_ShiftHistory : UserControl
    {
        public UC_ShiftHistory()
        {
            InitializeComponent();
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        public async Task UpdateGrid()
        {
            // Инициализация BindingSource
            var bindingSource = new BindingSource();

            // Получение текущего пользователя
            var userId = Settings.Default.user_id;

            // Загрузка смен текущего пользователя
            var shifts = (await new Shift().OnLoadAsync())
                .Where(shift => shift.shift_user_id == userId)
                .ToList();

            // Загрузка пользователей для сопоставления
            var users = await new User().OnAllUserAsync();

            // Связывание пользователей с каждой сменой
            foreach (var shift in shifts)
            {
                shift.user = users.FirstOrDefault(u => u.user_id == shift.shift_user_id);
            }

            // Привязка данных к DataGridView
            bindingSource.DataSource = shifts;
            dgvMain.DataSource = bindingSource;
        }

        private void DgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMain.CurrentCell.RowIndex;

            var selectedShift = (Shift)dgvMain.Rows[index].DataBoundItem;
            var window = new FrmOrdersList(selectedShift.shift_id);
            window.ShowDialog();
        }
    }
}
