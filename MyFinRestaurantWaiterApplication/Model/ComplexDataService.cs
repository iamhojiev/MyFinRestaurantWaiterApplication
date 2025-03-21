using RestSharp;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using MyFinCassa.Database;
using System.Threading.Tasks;
using MyFinCassa.Helper;

namespace MyFinCassa.Model
{
    public class ComplexDataService
    {
        private static readonly RestClient client = new RestClient(DataSQL.URL + @"/complex");

        public List<Product> Products { get; internal set; }
        public List<OrderDetails> OrderDetails { get; internal set; }

        public async Task<List<Order>> GetOrdersForPrintAsync()
        {
            var request = new RestRequest("/load_print_orders.php");
            var response = await client.PostAsync(request);

            // Используем наш парсер для получения вложенной структуры заказов:
            List<Order> orders = OrdersParser.DeserializePrintOrders(response.Content);
            return orders;
        }


        public async Task<ComplexDataService> OnLoadAllProdsAsync(int main_order_id, bool initProds = false)
        {
            //var req = new RestRequest("/load_allproducts.php")
            //    .AddParameter("order_main", main_order_id);

            //var res = await client.PostAsync(req);
            //var source = DeserializeComplexDataAsync(res.Content, initProds);

            //return source;
            return null;
        }
    }
}
