using RestSharp;
using System.Collections.Generic;
using MyFinCassa.Database;
using MyFinCassa.Properties;
using System.Numerics;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Client
    {
        public int client_id { get; set; }
        public string client_name { get; set; }
        public string client_address { get; set; }
        public string client_phone { get; set; }
        public double client_debt { get; set; }

        private static readonly RestClient client = new RestClient(DataSQL.URL + @"/client");

        public async Task<List<Client>> OnLoadAsync()
        {
            var req = new RestRequest("/load_client.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Client>(res.Content);

            return source;
        }

        public async Task<List<Client>> OnLoadDebtorsAsync()
        {
            var req = new RestRequest("/load_debtors.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Client>(res.Content);

            return source;
        }

        public async Task<bool> OnInsertAsync(Client cl)
        {
            var req = new RestRequest("/insert_client.php")
                .AddParameter("client_name", cl.client_name)
                .AddParameter("client_address", cl.client_address)
                .AddParameter("client_phone", cl.client_phone)
                .AddParameter("client_debt", cl.client_debt);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<bool> OnUpdateAsync(Client cl)
        {
            var existing = await OnSelectAsync(cl.client_id);
            var req = new RestRequest("/update_client.php")
                .AddParameter("client_id", cl.client_id)
                .AddParameter("client_debt", cl.client_debt);

            var res = await client.PostAsync(req);

            if (res.IsSuccessful)
            {
                var str = $"Изменил данные клиента:\nИмя: {cl.client_name}\nДолг до: {existing?.client_debt}\nДолг после: {cl.client_debt}";
                await Debug.DebugInsertAsync(str, Settings.Default.user_id);
                return true;
            }
            return false;
        }

        public async Task<Client> OnSelectAsync(int id)
        {
            var req = new RestRequest("/select_client.php")
                .AddParameter("client_id", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Client>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<Client> OnSelectLastAsync()
        {
            var req = new RestRequest("/select_last_client.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Client>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<bool> OnDeleteAsync(Client deleted)
        {
            var req = new RestRequest("/delete_client.php")
                .AddParameter("client_id", deleted.client_id);

            var res = await client.PostAsync(req);

            if (res.IsSuccessful)
            {
                var str = $"Удалил клиента:\nИмя: {deleted.client_name}";
                await Debug.DebugInsertAsync(str, Settings.Default.user_id);
                return true;
            }
            return false;
        }

    }
}
