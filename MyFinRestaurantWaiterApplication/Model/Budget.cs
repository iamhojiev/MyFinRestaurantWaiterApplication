using RestSharp;
using MyFinCassa.Database;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Balance
    {
        public int budget_id { get; set; }
        public string budget_name { get; set; }
        public double budget_money { get; set; }
        // public double budget_card { get; set; }

        private static readonly RestClient client = new RestClient(DataSQL.URL + @"/budget");

        public async Task<Balance> OnLoadAsync()
        {
            var req = new RestRequest("/load_budget.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Balance>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<bool> OnUpdateBalance(double newBalance)
        {
            RestRequest req = new RestRequest("/update_budget.php")
                .AddParameter("budget_money", newBalance);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }
    }
}
