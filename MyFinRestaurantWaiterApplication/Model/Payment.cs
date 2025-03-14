using System.Threading.Tasks;
using MyFinCassa.Database;
using RestSharp;

namespace MyFinCassa.Model
{
    public class Payment
    {
        public double payment_percent { get; set; }
        public double payment_fix { get; set; }
        public int payment_type { get; set; }

        public async Task<double> OnGetPercentAsync()
        {
            var payment = await OnLoadAsync();
            return payment.payment_percent;
        }

        public async Task<double> OnGetFixAsync()
        {
            var payment = await OnLoadAsync();
            return payment.payment_fix;
        }

        private static RestClient client = new RestClient(DataSQL.URL + @"/payment");

        public async Task<Payment> OnLoadAsync()
        {
            var req = new RestRequest("/load_payment.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Payment>(res.Content);

            return source[0];
        }

    }
}
