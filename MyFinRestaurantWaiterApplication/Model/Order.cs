using MyFinCassa.Database;
using MyFinCassa.Helper;
using System.Collections.Generic;
using RestSharp;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Order
    {
        public int order_id { get; set; }
        public int order_sub { get; set; }
        public int order_main { get; set; }
        public int order_table { get; set; }
        public int print_status { get; set; }
        public string order_date { get; set; }
        public string order_close_date { get; set; }
        public double order_price { get; set; }
        public double order_discount { get; set; }
        public int order_user { get; set; }
        public int order_guest { get; set; }
        public int order_shift { get; set; }
        public int order_payment { get; set; }
        public int order_status { get; set; }
        public int order_delivery { get; set; }
        public string order_comment { get; set; }
        public int order_status_cook { get; set; }
        public double order_price_waiter { get; set; }
        public double order_price_hall { get; set; }

        public User user { get; set; }
        public Tables tables { get; set; }
        public List<OrderDetails> orderDetails { get; set; }

        public string GetUserName { get { return user?.user_name; } }
        public string GetTableName { get { return tables?.table_name; } }
        public string GetHallName { get { return tables?.hall?.hall_name; } }
        public string GetOrderComment { get { return string.IsNullOrEmpty(order_comment) ? "-" : order_comment; } }

        public string OrderNum
        {
            get
            {
                string str;
                if (order_sub == 0)
                    str = $"{order_main}";
                else
                    str = $"{order_main}.{order_sub}";
                return str;
            }
        }
        public string CloseDate
        {
            get
            {
                return order_status == (int)EnumOrderStatus.Paid ? order_close_date : "-";
            }
        }

        public string OrderStatus
        {
            get
            {
                var str = "";
                switch (order_status)
                {
                    case (int)EnumOrderStatus.Paid: str = "Оплачен"; break;
                    case (int)EnumOrderStatus.NotPaid: str = "Не оплачен"; break;
                    case (int)EnumOrderStatus.Cancel: str = "Отменен"; break;
                };

                return str;
            }
        }

        public string OrderStatusDetails
        {
            get
            {
                var str = "";
                switch (order_status_cook)
                {
                    case (int)EnumDetailsStatus.Submited: str = "На готовке"; break;
                    case (int)EnumDetailsStatus.Edit: str = "На готовке"; break;
                    case (int)EnumDetailsStatus.NewOrder: str = "На готовке"; break;
                    case (int)EnumDetailsStatus.Ready: str = "Подано"; break;
                    case (int)EnumDetailsStatus.Return: str = "На готовке"; break;
                };

                return str;
            }
        }

        private static readonly RestClient client = new RestClient(DataSQL.URL + @"/order");

        public async Task<bool> OnUpdatePrintStatusAsync(Order order)
        {
            var req = new RestRequest("/update_print_status.php")
                .AddParameter("order_id", order.order_id)
                .AddParameter("print_status", order.print_status);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<bool> OnDeleteOrderAsync(int id)
        {
            var req = new RestRequest("/delete_order.php")
                .AddParameter("order_id", id);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<Order> SelectOrdersForPrintAsync()
        {
            var req = new RestRequest("/select_print_order.php");

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<List<Order>> OnLoadShiftAsync(int index)
        {
            var req = new RestRequest("/load_order_shift.php")
                .AddParameter("order_shift", index);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source;
        }

        public async Task<List<Order>> OnSelectUserAsync(int id)
        {
            var req = new RestRequest("/select_user_order.php")
                .AddParameter("order_user", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source;
        }

        public async Task<List<Order>> OnSelectMyOrdersCassaAsync(int id)
        {
            var req = new RestRequest("/select_myorders_cassa.php")
                .AddParameter("order_user", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source;
        }

        public async Task<List<Order>> OnSelectAllOrdersCassaAsync()
        {
            var req = new RestRequest("/select_all_order_cassa.php");

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source;
        }


        public async Task<Order> OnSelectLastAsync()
        {
            var req = new RestRequest("/select_last_order.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<Order> OnSelectLastSubOrderAsync(int main_order)
        {
            var req = new RestRequest("/select_last_sub_order.php")
                .AddParameter("order_main", main_order);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<List<Order>> SelectAllOrdersAndSubOrdersAsync(int main_order)
        {
            var req = new RestRequest("/select_all_order_sub_order.php")
                .AddParameter("order_main", main_order);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source;
        }

        public async Task<List<Order>> OnSelectActiveOrders()
        {
            var req = new RestRequest("/load_active_orders.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source;
        }

        public async Task<Order> OnSelectIdAsync(int orderId)
        {
            var req = new RestRequest("/select_order_id.php")
                .AddParameter("order_id", orderId);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<List<Order>> OnLoadAsync()
        {
            var req = new RestRequest("/load_order.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source;
        }

        public async Task<List<Order>> OnLoadNewOrdersAsync()
        {
            var req = new RestRequest("/load_new_orders.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Order>(res.Content);

            return source;
        }


        public async Task<bool> DeleteNewOrdersAsync()
        {
            var req = new RestRequest("/delete_new_orders.php");

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<bool> OnInsertAsync(Order order)
        {
            var req = new RestRequest("/insert_order.php")
                .AddParameter("order_main", order.order_main)
                .AddParameter("order_sub", order.order_sub)
                .AddParameter("order_price", DataSQL.ConvertDouble(order.order_price))
                .AddParameter("order_discount", DataSQL.ConvertDouble(order.order_discount))
                .AddParameter("order_table", order.order_table)
                .AddParameter("order_status", order.order_status)
                .AddParameter("order_date", order.order_date)
                .AddParameter("order_user", order.order_user)
                .AddParameter("order_guest", order.order_guest)
                .AddParameter("order_shift", order.order_shift)
                .AddParameter("order_close_date", order.order_close_date)
                .AddParameter("order_delivery", order.order_delivery)
                .AddParameter("order_comment", order.order_comment)
                .AddParameter("order_price_waiter", order.order_price_waiter)
                .AddParameter("order_price_hall", order.order_price_hall)
                .AddParameter("order_payment", order.order_payment);

            var res = await client.PostAsync(req);

            if (!res.IsSuccessful)
            {
                return false;
            }
            else
            {
                await DeleteNewOrdersAsync();
                return true;
            }
        }

        public async Task<bool> OnUpdateAsync(Order order)
        {
            var req = new RestRequest("/update_order.php")
                .AddParameter("order_main", order.order_main)
                .AddParameter("order_sub", order.order_sub)
                .AddParameter("order_price", DataSQL.ConvertDouble(order.order_price))
                .AddParameter("order_discount", DataSQL.ConvertDouble(order.order_discount))
                .AddParameter("order_table", order.order_table)
                .AddParameter("order_id", order.order_id)
                .AddParameter("order_status", order.order_status)
                .AddParameter("order_close_date", order.order_close_date)
                .AddParameter("order_shift", order.order_shift)
                .AddParameter("order_comment", order.order_comment)
                .AddParameter("order_status_cook", order.order_status_cook)
                .AddParameter("order_price_waiter", order.order_price_waiter)
                .AddParameter("order_price_hall", order.order_price_hall)
                .AddParameter("print_status", order.print_status)
                .AddParameter("order_payment", order.order_payment);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<bool> OnWaiterUpdateAsync(Order order)
        {
            var req = new RestRequest("/update_waiter.php")
                .AddParameter("order_id", order.order_id)
                .AddParameter("order_user", order.order_user);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<bool> OnUpdateStatusAsync(Order order)
        {
            var req = new RestRequest("/update_order_status.php")
                .AddParameter("order_id", order.order_id)
                .AddParameter("order_status", order.order_status)
                .AddParameter("print_status", order.print_status);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }
    }
}
