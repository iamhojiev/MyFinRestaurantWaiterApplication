using RestSharp;
using System.Collections.Generic;
using MyFinCassa.Database;
using MyFinCassa.Properties;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Card
    {
        public int card_id { get; set; }
        public string card_name { get; set; }
        public double card_balance { get; set; }

        private static RestClient client = new RestClient(DataSQL.URL + @"/card");

        public async Task<List<Card>> OnLoadAsync()
        {
            var req = new RestRequest("/load_card.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Card>(res.Content);

            return source;
        }

        public async Task<bool> OnInsertAsync(Card card)
        {
            var req = new RestRequest("/insert_card.php")
                .AddParameter("card_name", card.card_name)
                .AddParameter("card_balance", card.card_balance);

            var res = await client.PostAsync(req);

            if (res.IsSuccessful)
            {
                var str = $"Добавил новую карту: '{card.card_name}'";
                await Debug.DebugInsertAsync(str, Settings.Default.user_id);
                return true;
            }
            return false;
        }

        public async Task<bool> OnUpdateAsync(Card updated)
        {
            var existing = await OnSelectAsync(updated.card_id);
            var req = new RestRequest("/update_card.php")
                .AddParameter("card_id", updated.card_id)
                .AddParameter("card_name", updated.card_name)
                .AddParameter("card_balance", updated.card_balance);

            var res = await client.PostAsync(req);

            if (res.IsSuccessful)
            {
                var str = $"Баланс карты '{existing?.card_name}' был изменен:\nБыло: {existing?.card_balance}\nСтало: {updated.card_balance}";
                await Debug.DebugInsertAsync(str, Settings.Default.user_id);
                return true;
            }
            return false;
        }

        public async Task<Card> OnSelectAsync(int id)
        {
            var req = new RestRequest("/select_card.php")
                .AddParameter("card_id", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Card>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<bool> OnDeleteAsync(Card deleted)
        {
            var req = new RestRequest("/delete_card.php")
                .AddParameter("card_id", deleted.card_id);

            var res = await client.PostAsync(req);

            if (res.IsSuccessful)
            {
                var str = $"Удалил карту: '{deleted.card_name}'";
                await Debug.DebugInsertAsync(str, Settings.Default.user_id);
                return true;
            }
            return false;
        }

    }
}
