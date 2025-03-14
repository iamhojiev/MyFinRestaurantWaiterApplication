using MyFinCassa.UI_Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;

namespace MyFinCassa.UC
{
    public partial class UC_IncomingInfo : UserControl
    {
        private List<Order> orders = new List<Order>();
        private DateTime startPeriod = DateTime.Today;
        private DateTime endPeriod = DateTime.Today;
        private readonly BindingSource bs = new BindingSource();

        public UC_IncomingInfo()
        {
            InitializeComponent();
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            InitComboBoxesAsync();
        }

        private async void InitComboBoxesAsync()
        {
            try
            {
                // Загрузка данных
                var users = new List<User> { new User { user_name = "Показать все" } };
                users.AddRange(await new User().OnAllUserAsync());

                var tables = new List<Tables> { new Tables { table_name = "Показать все" } };
                tables.AddRange(await new Tables().OnLoadAsync());

                var halls = new List<Hall> { new Hall { hall_name = "Показать все" } };
                halls.AddRange(await new Hall().OnLoadAllAsync());

                // Настройка ComboBox
                cmbUser.ValueMember = "user_id";
                cmbUser.DisplayMember = "user_name";
                cmbUser.DataSource = users;

                cmbTable.ValueMember = "table_name";
                cmbTable.DisplayMember = "table_name";
                cmbTable.DataSource = tables;

                cmbHall.ValueMember = "hall_name";
                cmbHall.DisplayMember = "hall_name";
                cmbHall.DataSource = halls;

                // Установка начальных значений
                cmbPeriod.SelectedIndex = 0;
                cmbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при инициализации данных: {ex.Message}");
            }
        }

        private void cmbPeriodIndexChange(object sender, EventArgs e)
        {
            try
            {
                endPeriod = DateTime.Today;
                startPeriod = DateTime.Today;

                switch (cmbPeriod.SelectedIndex)
                {
                    case 0: startPeriod = endPeriod.AddDays(-1); break;
                    case 1: startPeriod = endPeriod.AddDays(-7); break;
                    case 2: startPeriod = endPeriod.AddMonths(-1); break;
                    case 3: startPeriod = endPeriod.AddMonths(-3); break;
                    case 4: startPeriod = endPeriod.AddMonths(-6); break;
                    case 5: startPeriod = endPeriod.AddYears(-1); break;
                    case 6: // Весь период
                        startPeriod = DateTime.MinValue;
                        endPeriod = DateTime.MaxValue;
                        break;
                }

                otDate.Text = startPeriod.ToString("yyyy-MM-dd");
                doDate.Text = endPeriod.ToString("yyyy-MM-dd");

                IncomingGridUpdateAsync();
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при выборе периода: {ex.Message}");
            }
        }

        private async void IncomingGridUpdateAsync()
        {
            try
            {
                bs.Clear();

                // Загрузка данных
                var tables = await new Tables().OnLoadAsync();
                var halls = await new Hall().OnLoadAllAsync();
                var users = await new User().OnAllUserAsync();

                int selectedUserId = (cmbUser.SelectedItem as User)?.user_id ?? 0;
                string selectedTableName = (cmbTable.SelectedItem as Tables)?.table_name ?? "Показать все";
                string selectedHallName = (cmbHall.SelectedItem as Hall)?.hall_name ?? "Показать все";

                orders = await new Order().OnLoadAsync();

                // Применение фильтров
                var filteredOrders = orders
                    .Where(o => DateTime.TryParse(o.order_date, out var orderDate) &&
                                orderDate >= startPeriod && orderDate <= endPeriod)
                    .Where(o => cmbStatus.SelectedIndex == 0 ||
                                (cmbStatus.SelectedIndex == 1 && o.order_status == (int)EnumOrderStatus.Paid) ||
                                (cmbStatus.SelectedIndex == 2 && o.order_status == (int)EnumOrderStatus.NotPaid))
                    .Select(o =>
                    {
                        o.tables = tables.FirstOrDefault(t => t.table_id == o.order_table);
                        o.tables.hall = halls.FirstOrDefault(h => h.hall_id == o.tables?.table_hall_id);
                        o.user = users.FirstOrDefault(u => u.user_id == o.order_user);
                        return o;
                    })
                    .Where(o => (selectedUserId == 0 || o.user?.user_id == selectedUserId) &&
                                (selectedTableName == "Показать все" || o.tables?.table_name == selectedTableName) &&
                                (selectedHallName == "Показать все" || o.tables?.hall?.hall_name == selectedHallName))
                    .ToList();

                // Подсчет общей стоимости
                double priceTotal = filteredOrders.Sum(o => o.order_price);

                // Обновление DataGridView
                dgvMain.DataSource = filteredOrders;
                txtInfo.Text = $"Количество наименований: {filteredOrders.Count}      Общая стоимость: {priceTotal:F2}";
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при обновлении данных: {ex.Message}");
            }
        }

        private void cmbFiltersChangeIndex(object sender, EventArgs e)
        {
            IncomingGridUpdateAsync();
        }

        private void dgvMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= dgvMain.Rows.Count)
                {
                    Dialog.Error("Неверная строка для выбора.");
                    return;
                }

                var selectedOrder = dgvMain.Rows[e.RowIndex].DataBoundItem as Order;
                if (selectedOrder == null)
                {
                    Dialog.Error("Не удалось выбрать заказ.");
                    return;
                }

                var window = new FrmOrderDetails(selectedOrder);
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при открытии деталей заказа: {ex.Message}");
            }
        }
    }

}
