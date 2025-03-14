using MyFinCassa.Database;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Hall
    {
        public int hall_id { get; set; }
        public string hall_name { get; set; }
        public double hall_price { get; set; }
        public int hall_bonus { get; set; }
        public int hall_type { get; set; }
        public List<Tables> tables { get; set; }


        private static RestClient client = new RestClient(DataSQL.URL + @"/hall");

        public async Task<List<Hall>> OnLoadHallsAsync()
        {
            var req = new RestRequest("/load_hall.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Hall>(res.Content);

            return source;
        }

        public async Task<List<Hall>> OnLoadAllAsync()
        {
            var req = new RestRequest("/load_all.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Hall>(res.Content);

            return source;
        }

        public async Task<List<Hall>> OnLoadDeliveriesAsync()
        {
            var req = new RestRequest("/load_delivery.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Hall>(res.Content);

            return source;
        }

        public async Task<Hall> OnSelectHallAsync(int id)
        {
            var req = new RestRequest("/select_hall.php")
                .AddParameter("hall_id", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Hall>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

    }
}
