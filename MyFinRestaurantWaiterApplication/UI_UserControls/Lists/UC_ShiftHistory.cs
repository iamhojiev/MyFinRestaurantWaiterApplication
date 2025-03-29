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
            var userId = Settings.Default.user_id;

            // Параллельная загрузка всех данных
            var loadShiftsTask = new Shift().LoadUserShiftsAsync(userId);
            var loadUsersTask = new User().OnAllUserAsync();
            var loadOrdersTask = new Order().OnLoadAsync();

            await Task.WhenAll(loadShiftsTask, loadUsersTask, loadOrdersTask);

            var userShifts = await loadShiftsTask;
            var users = await loadUsersTask;
            var orders = await loadOrdersTask;

            // Связывание пользователей с каждой сменой
            foreach (var shift in userShifts)
            {
                shift.user = users.FirstOrDefault(u => u.user_id == shift.shift_user_id);
                shift.shiftOrders = orders.Where(or => or.order_shift == shift.shift_id).ToList();
            }

            dgvMain.DataSource = userShifts;
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
