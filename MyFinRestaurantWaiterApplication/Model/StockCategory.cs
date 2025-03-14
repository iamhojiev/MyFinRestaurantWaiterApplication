using MyFinCassa.Database;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class StockCategory
    {
        public int st_cat_id { get; set; }
        public string st_cat_name { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/stock_category");

        public async Task<List<StockCategory>> OnLoadAsync()
        {
            var req = new RestRequest("/load_stock_category.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<StockCategory>(res.Content);

            return source;
        }
    }
}
