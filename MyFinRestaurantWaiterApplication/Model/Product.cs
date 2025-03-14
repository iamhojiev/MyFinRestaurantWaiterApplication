using RestSharp;
using System.Collections.Generic;
using MyFinCassa.Database;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Product
    {
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public double prod_price { get; set; }
        public int prod_cooking_minutes { get; set; }
        public double prod_total { get; set; }
        public int prod_value { get; set; }
        public int prod_category { get; set; }
        public int prod_type { get; set; }
        public int prod_sub_order { get; set; }
        public double prod_start_price { get; set; }
        public int prod_kitchen { get; set; }
        public int prod_status { get; set; }
        public string prod_comment { get; set; }
        public Kitchen kitchen { get; set; }
        public Category category {get;set;}
        public Type type { get; set; }
        public List<Recipe> recipe { get; set; }
        public List<OrderDetails> orderDetails { get; set; }
        public string GetTypeName { get { return type?.type_name; } }
        public double Sum
        {
            get
            {
                return prod_price * prod_total;
            }
        }

        private static RestClient client = new RestClient(DataSQL.URL + @"/product");

        public async Task<Product> OnSelectAsync(int prod_id)
        {
            var req = new RestRequest("/select_product.php")
                .AddParameter("prod_id", prod_id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Product>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<Product> OnSelectLastAsync()
        {
            var req = new RestRequest("/select_last_product.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Product>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<List<Product>> OnLoadAsync()
        {
            var req = new RestRequest("/load_product.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Product>(res.Content);

            return source;
        }
    }
}
