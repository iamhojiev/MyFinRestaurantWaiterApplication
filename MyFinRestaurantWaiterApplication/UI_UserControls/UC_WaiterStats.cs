using System;
using System.Data;
using System.Linq;
using MyFinCassa.UI_Forms;
using System.Collections.Generic;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using System.Threading.Tasks;

namespace MyFinCassa.UC
{
    public partial class UC_WaiterStats : UserControl
    {
        private List<Order> orders = new List<Order>();

        public UC_WaiterStats()
        {
            InitializeComponent();
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            InitComboBoxesAsync().ConfigureAwait(false);
        }

        private async Task InitComboBoxesAsync()
        {
            // Инициализация списка пользователей с проверкой на null
            var allUsers = await new User().OnAllUserAsync() ?? new List<User>();

            var users = new List<User>
        {
            new User { user_name = "Показать все" },
        };
            users.AddRange(allUsers);

            // Проверяем, есть ли данные для отображения
            if (users.Count == 0)
            {
                Dialog.Error("Не удалось загрузить список пользователей.");
                return;
            }

            cmbUser.ValueMember = "user_id";
            cmbUser.DisplayMember = "user_name";
            cmbUser.DataSource = users;

            cmbUser.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
        }

        private async void UpdateGrid()
        {

            BindingSource bs = new BindingSource();
            orders.Clear();

            int filter = cmbFilter.SelectedIndex;
            int myUser = Convert.ToInt32(cmbUser.SelectedValue);

            // Загружаем заказы на основе фильтра
            orders = cmbUser.SelectedIndex == 0
               ? await new Order().OnLoadAsync() ?? new List<Order>()
               : await new Order().OnSelectUserAsync(myUser) ?? new List<Order>();

            // Применяем фильтры
            if (filter == 1)
            {
                orders = orders.Where(u => u.order_status == (int)EnumOrderStatus.Paid).ToList();
            }
            else if (filter == 2)
            {
                orders = orders.Where(u => u.order_status == (int)EnumOrderStatus.NotPaid).ToList();
            }

            // Загружаем связанные данные
            var tables = await new Tables().OnLoadAsync() ?? new List<Tables>();
            var halls = await new Hall().OnLoadAllAsync() ?? new List<Hall>();
            var users = await new User().OnAllUserAsync() ?? new List<User>();

            double priceTotal = 0.0;
            double waiterMoney = 0.0;

            foreach (var order in orders)
            {
                // Проверяем связи с таблицами, залами и пользователями
                order.tables = tables.FirstOrDefault(t => t.table_id == order.order_table);
                if (order.tables != null)
                {
                    order.tables.hall = halls.FirstOrDefault(h => h.hall_id == order.tables.table_hall_id);
                }
                order.user = users.FirstOrDefault(u => u.user_id == order.order_user);

                // Суммируем данные
                priceTotal += order.order_price;
                waiterMoney += order.order_price_waiter;

                bs.Add(order);
            }

            // Обновляем DataGridView
            dgvMain.DataSource = bs;
            label1.Text = string.Format(
                "Количество наименований: {0}   Общая сумма: {1:N2}    Официантам Итого: {2:N2}",
                dgvMain.Rows.Count, priceTotal, waiterMoney);
        }

        private void CmbFilter_SelectionChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверка на корректность выбранной строки
            if (e.RowIndex < 0 || e.RowIndex >= dgvMain.Rows.Count) return;

            Order order = dgvMain.Rows[e.RowIndex].DataBoundItem as Order;
            if (order == null)
            {
                Dialog.Error("Не удалось загрузить детали заказа.");
                return;
            }

            var detailsWindow = new FrmOrderDetails(order);
            detailsWindow.ShowDialog();
        }
    }
}
