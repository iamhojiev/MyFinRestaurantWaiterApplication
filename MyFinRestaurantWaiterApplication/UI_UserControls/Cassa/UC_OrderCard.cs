using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MyFinCassa.Model;
using MyFinCassa.Helper;
using Guna.UI2.WinForms;
using System.Linq;
using System.Threading.Tasks;


namespace MyFinCassa.UI_UserControls.Cassa
{
    public partial class UC_OrderCard : UserControl
    {
        private string currency;
        public double fullPrice;
        private bool printer;
        public Order myOrder;
        private List<Product> products = new List<Product>();
        private List<OrderDetails> details = new List<OrderDetails>();

        public UC_OrderCard(string currency)
        {
            InitializeComponent();
            this.currency = currency;
            InitPrinter();
        }

        private async void InitPrinter()
        {
            var settings = new CassaSettings();
            printer = await settings.IsPrinterCookingOutputAsync();
        }

        public void InitAddButton()
        {
            this.Tag = null;
            fullPrice = 0;
            flowLayoutPanel.Controls.Clear();
            pnlOrderInfo.SendToBack();
            pnlBtn.BringToFront();
            timer.Stop();
        }

        public void TemporablyInitButton()
        {
            pnlOrderInfo.SendToBack();
            pnlBtn.BringToFront();
        }

        public void TemporablyInitCard()
        {
            pnlOrderInfo.BringToFront();
            pnlBtn.SendToBack();
        }

        public void InitOrder(Order order)
        {
            if (order == null) return;

            pnlOrderInfo.BringToFront();
            pnlBtn.SendToBack();
            myOrder = order;
            this.Tag = order;
            var orderDate = DateTime.Parse(order.order_date);
            txtDate.Text = $"{orderDate.Hour}:{orderDate.Minute:D2}";
            txtWaiter.Text = order.user.user_name;

            txtHall.Text = $"{order.tables.hall.hall_name}";
            if (order.order_delivery == (int)EnumOrderType.Default)
                txtTable.Text = $"{order.tables.table_name}";
            else
            {
                pnlTable.Visible = false;
            }

            UpdateOrder(order); // Now await the method
        }

        public async void UpdateOrder(Order order)
        {
            if (order == null) return;

            flowLayoutPanel.Controls.Clear();
            fullPrice = await CalculateFullPrice(order);
            txtPrice.Text = $"{fullPrice:F2} {currency}";

            await UpdateProducts(order);
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer.Interval = printer ? 60000 : 8000;
            timer.Tick += printer ? (EventHandler)CheckProductsCooking : CheckForProductsUpdate;
            timer.Start();
        }

        public void UpdateWaiter(string waiterName)
        {
            txtWaiter.Text = waiterName;
        }

        public void UpdateTable(Tables newTable)
        {
            txtHall.Text = $"{newTable.hall.hall_name}: {newTable.table_name}";
        }

        private async Task UpdateProducts(Order order)
        {
            var complexData = await new DetailsProductComplex().OnLoadAllProdsAsync(order.order_main, true);
            if (complexData?.Products != null)
            {
                products = complexData.Products;
                details = complexData.OrderDetails;
                AddProductsToFlowLayout(products);
            }
        }

        private void AddProductsToFlowLayout(List<Product> products)
        {
            if (products == null || products.Count == 0) return;

            var productsGroupBySubOrder = products.GroupBy(p => p.prod_sub_order).ToList();

            foreach (var group in productsGroupBySubOrder)
            {
                foreach (var product in group)
                {
                    var uC_Detail = new UC_Detail(product);
                    flowLayoutPanel.Controls.Add(uC_Detail);
                }

                // Add separator between groups
                if (group != productsGroupBySubOrder.Last())
                {
                    flowLayoutPanel.Controls.Add(CreateSeparator());
                }
            }
        }

        private Guna2VSeparator CreateSeparator()
        {
            return new Guna2VSeparator
            {
                Size = new System.Drawing.Size(10, this.Size.Height - 5),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom
            };
        }

        private static async Task<double> CalculateFullPrice(Order order)
        {
            var orders = await new Order().SelectAllOrdersAndSubOrdersAsync(order.order_main);
            if (orders != null)
            {
                return orders.Sum(o => o.order_price);
            }
            return 0;  // Return 0 if no valid data
        }

        private int elapsedMinutes;
        private async void CheckProductsCooking(object sender, EventArgs e)
        {
            elapsedMinutes++;

            bool updated = await UpdateProductStatuses();

            if (updated)
            {
                UpdateMyDetails();
            }

            CheckForProductStatus();
        }

        private async Task<bool> UpdateProductStatuses()
        {
            bool updated = false;

            if (products == null || products.Count == 0) return updated;

            foreach (var product in products)
            {
                if (product.prod_status != (int)EnumDetailsStatus.Ready &&
                    elapsedMinutes >= product.prod_cooking_minutes)
                {
                    product.prod_status = (int)EnumDetailsStatus.Ready;
                    var detail = details?.FirstOrDefault(d => d.details_prod == product.prod_id);
                    if (detail != null)
                    {
                        detail.details_status = (int)EnumDetailsStatus.Ready;
                        await detail.OnUpdateStatusAsync(detail);
                        updated = true;
                    }
                }
            }

            return updated;
        }

        private void UpdateMyDetails()
        {
            flowLayoutPanel.Controls.Clear();
            AddProductsToFlowLayout(products);
        }

        private void CheckForProductStatus()
        {
            // Check if all products are ready
            if (products != null && products.All(p => p.prod_status == (int)EnumDetailsStatus.Ready))
            {
                timer.Stop();
            }
        }

        private async void CheckForProductsUpdate(object sender, EventArgs e)
        {
            if (myOrder != null)
            {
                var complexData = await new DetailsProductComplex().OnLoadAllProdsAsync(myOrder.order_main, true);

                // Only update if the products list has changed
                if (complexData?.Products != null && !IsEqual(products, complexData.Products))
                {
                    products = complexData.Products;
                    UpdateMyDetails();
                }

                CheckForProductStatus();
            }
        }

        private bool IsEqual(List<Product> list1, List<Product> list2)
        {
            if (list1 == null || list2 == null || list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].prod_id != list2[i].prod_id ||
                    list1[i].prod_total != list2[i].prod_total ||
                    list1[i].prod_status != list2[i].prod_status)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
