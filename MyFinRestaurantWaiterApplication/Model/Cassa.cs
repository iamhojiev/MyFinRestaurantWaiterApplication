using RestSharp;
using System.Threading.Tasks;
using System.Collections.Generic;
using MyFinCassa.Database;
using MyFinCassa.Properties;

namespace MyFinCassa.Model
{
    public class Cassa
    {
        public int cassa_id { get; set; }
        public string cassa_name { get; set; }
        public double cassa_money { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/cassa");

        public async Task<List<Cassa>> OnLoadAsync()
        {
            var req = new RestRequest("/load_cassa.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Cassa>(res.Content);

            return source;
        }

        public async Task<bool> OnUpdateAsync(Cassa updated)
        {
            var existing = await OnSelectCassaAsync(updated.cassa_id);
            var req = new RestRequest("/update_cassa.php")
                .AddParameter("cassa_id", updated.cassa_id)
                .AddParameter("cassa_name", updated.cassa_name)
                .AddParameter("cassa_money", updated.cassa_money);

            var res = await client.PostAsync(req);

            if (res.IsSuccessful)
            {
                var str = $"Баланс кассы '{existing?.cassa_name}' был изменен:\nБыло: {existing?.cassa_money}\nСтало: {updated.cassa_money}";
                await Debug.DebugInsertAsync(str, Settings.Default.user_id);
                return true;
            }
            return false;
        }

        public async Task<Cassa> OnSelectCassaAsync(int id)
        {
            var req = new RestRequest("/select_cassa.php")
                .AddParameter("cassa_id", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Cassa>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }
    }
}
