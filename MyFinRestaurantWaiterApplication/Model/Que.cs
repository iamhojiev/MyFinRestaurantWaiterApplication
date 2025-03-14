using RestSharp;
using MyFinCassa.Database;
using static Guna.UI2.HtmlRenderer.Adapters.RGraphicsPath;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Que
    {
        public int que_num { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/que");

        public async Task<int> GetQueNumAsync()
        {
            var que = await new Que().OnLoadAsync();
            return que.que_num;
        }

        public async Task<Que> OnLoadAsync()
        {
            var req = new RestRequest("/load_que.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Que>(res.Content);

            return source[0];
        }

        public async Task<bool> IncrementAsync()
        {
            var incrementValue = (await new Que().OnLoadAsync()).que_num;
            incrementValue++;
            var req = new RestRequest("/update_que.php")
                .AddParameter("que_num", incrementValue);

            var res = await client.PostAsync(req);
            return res.IsSuccessful;
        }
    }
}
