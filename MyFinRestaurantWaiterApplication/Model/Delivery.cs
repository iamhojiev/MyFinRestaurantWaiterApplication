using RestSharp;
using System.Collections.Generic;
using MyFinCassa.Database;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Delivery
    {
        public int delivery_id { get; set; }
        public string delivery_name { get; set; }
        public string delivery_desc { get; set; }
        public double delivery_price { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/delivery");

        public async Task<List<Delivery>> OnLoadAsync()
        {
            var req = new RestRequest("/load_delivery.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Delivery>(res.Content);

            return source;
        }
    }
}
