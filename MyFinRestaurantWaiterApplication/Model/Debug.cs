using MyFinCassa.Database;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Debug
    {
        public int debug_id { get; set; }
        public int debug_admin { get; set; }
        public string debug_date { get; set; }
        public string debug_text { get; set; }

        public User user { get; set; }
        public string GetUserName { get { return user?.user_name; } }

        private static RestClient client = new RestClient(DataSQL.URL + @"/debug");

        public static async Task DebugInsertAsync(string text, int userId = 0)
        {
            var req = new RestRequest("/insert_debug.php")
                .AddParameter("debug_admin", userId)
                .AddParameter("debug_date", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())
                .AddParameter("debug_text", text);

            await client.PostAsync(req);
        }

        public async Task<List<Debug>> OnLoadAsync()
        {
            var req = new RestRequest("/load_debug.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Debug>(res.Content);

            return source;
        }

    }
}
