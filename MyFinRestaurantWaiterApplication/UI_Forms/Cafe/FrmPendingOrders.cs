using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinCassa.Database;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using static Guna.UI2.HtmlRenderer.Adapters.RGraphicsPath;
using Type = MyFinCassa.Model.Type;

namespace MyFinCassa.UI_Forms.Cafe
{

    public partial class FrmPendingOrders : Form
    {
        private BindingSource detailsBindingSource = new BindingSource();
        private List<User> users;
        private List<Type> types;
        private List<Product> products;
        private List<Tables> tables;
        private List<Hall> halls;

        public List<Product> SelectedOrderProducts { get; private set; } = new List<Product>();
        public Order SelectedOrder { get; private set; }

        public FrmPendingOrders()
        {
            InitializeComponent();
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            try
            {
                SetLoadingState(true);

                // Загружаем данные параллельно
                var userTask = new User().OnAllUserAsync();
                var productTask = new Product().OnLoadAsync();
                var typeTask = new Type().OnLoadAsync();
                var tableTask = new Tables().OnLoadAsync();
                var hallTask = new Hall().OnLoadAllAsync();

                users = await userTask;
                products = await productTask;
                types = await typeTask;
                tables = await tableTask;
                halls = await hallTask;

                await UpdateOrdersAsync();
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка загрузки данных: {ex.Message}");
            }
            finally
            {
                SetLoadingState(false);
            }
        }

        private async Task UpdateOrdersAsync()
        {
            try
            {
                BindingSource bs = new BindingSource();
                var orders = await new Order().OnSelectActiveOrders();

                double allOrdersPrice = 0.0;

                foreach (var order in orders)
                {
                    await InitializeOrderReferences(order);
                    allOrdersPrice += order.order_price;
                    bs.Add(order);
                }

                txtOrderInfo.Text = $"Заказов: {orders.Count} | Сумма: {allOrdersPrice:N2}";
                dgvOrders.DataSource = bs;

                if (dgvOrders.Rows.Count > 0)
                    dgvOrders.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка обновления заказов: {ex.Message}");
            }
        }

        private async Task InitializeOrderReferences(Order order)
        {
            order.user = users.FirstOrDefault(u => u.user_id == order.order_user);
            order.tables = tables.FirstOrDefault(t => t.table_id == order.order_table);
            if (order.tables != null)
            {
                order.tables.hall = halls.FirstOrDefault(h => h.hall_id == order.tables.table_hall_id);
            }

            await InitializeOrderDetails(order);
        }

        private async Task InitializeOrderDetails(Order order)
        {
            try
            {
                var details = await new OrderDetails().OnSelectAllOrderDetailsAsync(order.order_main);

                foreach (var detail in details)
                {
                    detail.product = products.FirstOrDefault(p => p.prod_id == detail.details_prod);
                    if (detail.product != null)
                    {
                        detail.product.type = types.FirstOrDefault(t => t.type_id == detail.product.prod_value);
                    }
                    detail.product.prod_total = detail.details_count;
                }

                order.orderDetails = details;
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка загрузки деталей заказа: {ex.Message}");
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                detailsBindingSource.Clear();
                SelectedOrderProducts.Clear();
                txtDetailsInfo.Text = $"Наименований: 0 | Количество: 0 | Сумма: 0 | Скидка: 0 | Итого: 0";
                return;
            }

            try
            {
                var selected = (Order)dgvOrders.SelectedRows[0].DataBoundItem;
                SelectedOrder = selected;
                InitializeDetails(selected);
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при выборе заказа: {ex.Message}");
            }
        }

        private void InitializeDetails(Order order)
        {
            detailsBindingSource.Clear();
            SelectedOrderProducts.Clear();

            double totalCounts = 0;
            double totalSum = 0;

            foreach (var detail in order.orderDetails)
            {
                totalCounts += detail.details_count;
                totalSum += detail.product.Sum;
                SelectedOrderProducts.Add(detail.product);
                detailsBindingSource.Add(detail);
            }

            txtDetailsInfo.Text = $"Наименований: {order.orderDetails.Count} | Количество: {totalCounts} | Сумма: {totalSum:N2} | Скидка: {order.order_discount:N2} | Итого: {order.order_price:N2}";
            dgvDetails.DataSource = detailsBindingSource;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedOrder == null)
            {
                Dialog.Error("Выберите заказ для удаления.");
                return;
            }

            var result = MessageBox.Show($"Вы уверены, что хотите удалить заказ №{SelectedOrder.OrderNum}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                await new Order().OnDeleteOrderAsync(SelectedOrder.order_id);
                await new OrderDetails().OnDeleteAsync(SelectedOrder.order_main, SelectedOrder.order_sub);
                await UpdateOrdersAsync();

                // Получаем список продуктов из заказа
                List<Product> products = SelectedOrder.orderDetails.Select(od => od.product).ToList();
                PrinterHelper.PrintOrderCancelReceipt(SelectedOrder, products);
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка удаления заказа: {ex.Message}");
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (SelectedOrder == null)
            {
                Dialog.Error("Выберите заказ для печати.");
                return;
            }

            PrinterHelper.PrintOrderReceipt(SelectedOrder);
        }

        private void SetLoadingState(bool isLoading)
        {
            dgvOrders.Enabled = !isLoading;
            dgvDetails.Enabled = !isLoading;
            btnDelete.Enabled = !isLoading;
            btnPrint.Enabled = !isLoading;
            Cursor = isLoading ? Cursors.WaitCursor : Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnToBasket_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
