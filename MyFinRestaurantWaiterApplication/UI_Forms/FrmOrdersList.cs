using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using MyFinCassa.Properties;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmOrdersList : Form
    {
        private readonly BindingSource bs = new BindingSource();
        private readonly int myChange;

        public FrmOrdersList(int change)
        {
            InitializeComponent();
            myChange = change;
            UpdateGrid();
        }

        private async void UpdateGrid()
        {
            bs.Clear();

            try
            {
                var myUser = Settings.Default.user_id;
                var orders = (await new Order().OnSelectUserAsync(myUser)).Where(u => u.order_shift == myChange).ToList();

                var tables = await new Tables().OnLoadAsync();
                var halls = await new Hall().OnLoadAllAsync();
                var users = await new User().OnAllUserAsync();

                var ordersWithDetails = orders.Select(order =>
                {
                    order.tables = tables.FirstOrDefault(t => t.table_id == order.order_table);
                    if (order.tables != null)
                    {
                        order.tables.hall = halls.FirstOrDefault(h => h.hall_id == order.tables.table_hall_id);
                    }
                    order.user = users.FirstOrDefault(u => u.user_id == order.order_user);
                    return order;
                }).ToList();

                foreach (var order in ordersWithDetails)
                {
                    bs.Add(order);
                }

                dgvMain.DataSource = bs;
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при обновлении таблицы заказов: {ex.Message}");
            }
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.CurrentRow?.DataBoundItem is Order order)
            {
                using (var window = new FrmOrderDetails(order))
                {
                    window.ShowDialog();
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
