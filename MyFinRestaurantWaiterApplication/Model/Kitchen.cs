using MyFinCassa.Database;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Kitchen
    {
        public int kitchen_id { get; set; }
        public string kitchen_name { get; set; }
        public string kitchen_printer { get; set; }
        public List<Product> product { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/kitchen");

        public async Task<List<Kitchen>> OnLoadAsync()
        {
            var req = new RestRequest("/load_kitchen.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Kitchen>(res.Content);

            return source;
        }

        public override bool Equals(object obj)
        {
            if (obj is Kitchen other)
            {
                return this.kitchen_id == other.kitchen_id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return kitchen_id.GetHashCode();
        }
    }
}
