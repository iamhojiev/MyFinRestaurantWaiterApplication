﻿using RestSharp;
using MyFinCassa.Database;
using System.Threading.Tasks;
using MyFinCassa.Helper;
using System.Collections.Generic;

namespace MyFinCassa.Model
{
    public class SalaryLog : TransactionLog
    {
        public EnumSalaryLogType transaction_salary_type { get; set; }
        public int transaction_salary_user { get; set; }

        public User salary_user { get; set; }

        public new async Task<List<SalaryLog>> OnLoadTransactionsAsync()
        {
            var req = new RestRequest("/load_salary_transactions.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<SalaryLog>(res.Content);

            return source;
        }
    }

}
