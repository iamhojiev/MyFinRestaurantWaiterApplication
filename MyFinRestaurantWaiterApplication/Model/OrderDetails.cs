using MyFinCassa.Database;
using MyFinCassa.Helper;
using System.Collections.Generic;
using RestSharp;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class OrderDetails
    {
        public int details_id { get; set; }
        public int details_prod { get; set; }
        public double details_count { get; set; }
        public int details_order { get; set; }
        public int details_sub_order { get; set; }
        public int details_status { get; set; }
        public string details_comment { get; set; }
        public Order order { get; set; }
        public Product product { get; set; }
        public string GetProductName { get { return product?.prod_name; } }
        public double GetProductPrice { get { return (double)(product?.prod_price); } }
        public double GetProductCount { get { return (double)(product?.prod_total); } }
        public string GetProductTypeName { get { return product?.type.type_name; } }
        public string GetDetailComment { get { return string.IsNullOrEmpty(details_comment) ? "-" : details_comment; } }

        private static RestClient client = new RestClient(DataSQL.URL + @"/details");
        public string OnStatusText
        {
            get
            {
                string str = "";
                switch (details_status)
                {
                    case (int)EnumDetailsStatus.Submited: str = "Принят"; break;
                    case (int)EnumDetailsStatus.Edit: str = "На готовке"; break;
                    case (int)EnumDetailsStatus.NewOrder: str = "На готовке"; break;
                    case (int)EnumDetailsStatus.Ready: str = "Подано"; break;
                    case (int)EnumDetailsStatus.Return: str = "Возврат"; break;
                }

                return str;
            }
        }

        public async Task<List<OrderDetails>> OnSelectAllOrderDetailsAsync(int order_id)
        {
            var req = new RestRequest("/select_order_details.php")
                .AddParameter("details_order", order_id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<OrderDetails>(res.Content);

            return source;
        }

        public async Task<List<OrderDetails>> OnSelectSubOrderDetailsAsync(int main_order_id, int sub_order_id)
        {
            var req = new RestRequest("/select_sub_order_details.php")
                .AddParameter("details_order", main_order_id)
                .AddParameter("details_sub_order", sub_order_id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<OrderDetails>(res.Content);

            return source;
        }

        public async Task<bool> OnInsertAsync(OrderDetails orderDetails)
        {
            var req = new RestRequest("/insert_order_details.php")
                .AddParameter("details_count", DataSQL.ConvertDouble(orderDetails.details_count))
                .AddParameter("details_prod", orderDetails.details_prod)
                .AddParameter("details_status", orderDetails.details_status)
                .AddParameter("details_comment", orderDetails.details_comment)
                .AddParameter("details_sub_order", orderDetails.details_sub_order)
                .AddParameter("details_order", orderDetails.details_order);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<bool> OnDeleteAsync(int details_order, int details_sub_order)
        {
            var req = new RestRequest("/delete_order_details.php")
                .AddParameter("details_order", details_order)
                .AddParameter("details_sub_order", details_sub_order);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<bool> OnUpdateStatusAsync(OrderDetails detail)
        {
            var req = new RestRequest("/update_order_details_status.php")
                .AddParameter("details_id", detail.details_id)
                .AddParameter("details_status", detail.details_status);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }
    }
}