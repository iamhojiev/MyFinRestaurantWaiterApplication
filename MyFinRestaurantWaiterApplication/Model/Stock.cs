using RestSharp;
using System.Collections.Generic;
using MyFinCassa.Database;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Stock
    {
        public int stock_id { get; set; }
        public string stock_name { get; set; }
        public double stock_count { get; set; }
        public double stock_price { get; set; }
        public int stock_value { get; set; }
        public int stock_category { get; set; }

        public Type type { get; set; }
        public StockCategory stockCategory { get; set; }

        public double Sum { get { return stock_count * stock_price; } }

        private static RestClient client = new RestClient(DataSQL.URL + @"/stock");

        public async Task<List<Stock>> OnLoadAsync()
        {
            var req = new RestRequest("/load_stock.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Stock>(res.Content);

            return source;
        }

        public async Task<bool> OnUpdateCountAsync(Stock stock)
        {
            var req = new RestRequest("/update_stock_count.php")
                .AddParameter("stock_id", stock.stock_id)
                .AddParameter("stock_count", DataSQL.ConvertDouble(stock.stock_count))
                .AddParameter("stock_price", DataSQL.ConvertDouble(stock.stock_price));

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }
    }
}
