using RestSharp;
using MyFinCassa.Database;
using System.Threading.Tasks;
using MyFinCassa.Helper;
using System.Collections.Generic;

namespace MyFinCassa.Model
{

    public class OrderCashLog : TransactionLog
    {
        public EnumPaymentType transaction_payment { get; set; }
        public int transaction_order { get; set; } // Для связи с заказами
        public int transaction_cassa { get; set; } // Для связи с кассой

        public async Task<List<OrderCashLog>> OnSelectOrderTransactionAsync(int order_id)
        {
            var req = new RestRequest("/select_order_transaction.php")
                .AddParameter("transaction_order", order_id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<OrderCashLog>(res.Content);

            return source;
        }
    }
}
