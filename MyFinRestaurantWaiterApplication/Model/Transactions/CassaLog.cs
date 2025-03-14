using RestSharp;
using MyFinCassa.Database;
using System.Threading.Tasks;
using MyFinCassa.Helper;
using System.Collections.Generic;

namespace MyFinCassa.Model
{
    public class CassaLog : TransactionLog
    {
        public int transaction_cassa { get; set; } // Для связи с кассой
        public double transaction_source_balance { get; set; }
        public EnumCassaOperationType transaction_cassa_operation { get; set; }  // Тип операции (Пополнение/Снятие)
        public EnumWithdrawalType? transaction_withdrawal_type { get; set; } // Тип снятия (только если CassaOperationType == Снятие)

        public Cassa cassa { get; set; }
        public Card card { get; set; }
        public string GetSourceString
        {
            get
            {
                switch (transaction_withdrawal_type)
                {
                    case EnumWithdrawalType.Безналичными:
                        return card?.card_name ?? "Неизвестная карта";
                    case EnumWithdrawalType.Наличными:
                        return cassa?.cassa_name ?? "Неизвестная касса";
                    default:
                        return "Неизвестный источник";
                }
            }
        }

        public new async Task<List<CassaLog>> OnLoadTransactionsAsync()
        {
            var req = new RestRequest("/load_cassa_transactions.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<CassaLog>(res.Content);

            return source;
        }
    }

}
