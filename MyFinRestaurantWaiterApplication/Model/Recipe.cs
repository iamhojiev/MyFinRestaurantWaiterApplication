using MyFinCassa.Database;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Recipe
    {
        public int recipe_id { get; set; }
        public int recipe_stock { get; set; }
        public int recipe_product { get; set; }
        public double recipe_count { get; set; }
        public int recipe_value { get; set; }

        public Type type { get; set; }
        public Stock stock { get; set; }
        public Product product { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/recipe");

        public async Task<List<Recipe>> OnSelectAsync(int id)
        {
            var req = new RestRequest("/select_product_recipe.php")
                .AddParameter("recipe_product", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Recipe>(res.Content);

            return source;
        }
    }
}
