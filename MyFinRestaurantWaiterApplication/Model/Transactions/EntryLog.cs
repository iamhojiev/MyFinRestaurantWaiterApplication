using RestSharp;
using MyFinCassa.Database;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyFinCassa.Model
{
    public class EntryLog : TransactionLog
    {
        public int transaction_entry { get; set; } // Для связи с приходом

        public async Task<List<EntryLog>> OnSelectEntryTransactionsAsync(int entryId)
        {
            var req = new RestRequest("/select_entry_transaction.php")
                .AddParameter("transaction_entry", entryId);

            var res = await client.PostAsync(req);

            return DataSQL.Deserialize<EntryLog>(res.Content);
        }
    }
}
