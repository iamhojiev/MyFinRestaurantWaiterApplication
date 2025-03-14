using MyFinCassa.Database;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Category
    {
        public int category_id {get;set;}
        public string category_name { get; set; }
        public List<Product> product { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/category");

        public async Task<List<Category>> OnLoadAsync()
        {
            var req = new RestRequest("/load_category.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Category>(res.Content);

            return source;
        }

    }
}
