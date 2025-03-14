using MyFinCassa.Database;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Role
    {
        public int role_id { get; set; }
        public string role_name { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/role");

        public async Task<List<Role>> OnLoadAsync()
        {
            var req = new RestRequest("/load_role.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Role>(res.Content);

            return source;
        }
    }
}
