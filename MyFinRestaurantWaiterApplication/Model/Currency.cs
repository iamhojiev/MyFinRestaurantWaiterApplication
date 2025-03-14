using RestSharp;
using MyFinCassa.Database;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Currency
    {
        public string currency_value { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/currency");

        public async Task<string> OnGetCurrencyValueAsync()
        {
            var currency = await OnLoadAsync();
            return currency.currency_value;
        }

        private async Task<Currency> OnLoadAsync()
        {
            var req = new RestRequest("/load_currency.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Currency>(res.Content);

            return source[0];
        }

    }
}
