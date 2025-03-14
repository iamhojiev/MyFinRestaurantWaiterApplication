using MyFinCassa.Database;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Tables
    {
        public int table_id { get; set; }
        public string table_name { get; set; }
        public int table_place { get; set; }
        public int table_hall_id { get; set; }
        public int table_status { get; set; }
        public string table_date { get; set; }
        public string table_time { get; set; }

        public TableStatus tables_status { get; set; }
        public Hall hall { get; set; }

        public string GetTableStatus { get { return tables_status?.table_st_name; } }
        public string GetHallName { get { return hall.hall_name; } }

        private static RestClient client = new RestClient(DataSQL.URL + @"/table");

        public async Task<List<Tables>> OnLoadAsync()
        {
            var req = new RestRequest("/load_tables.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Tables>(res.Content);

            return source;
        }

        public async Task<Tables> OnSelectTableAsync(int id)
        {
            var req = new RestRequest("/select_table.php")
                .AddParameter("table_id", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Tables>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<bool> OnUpdateStatusAsync(Tables tables)
        {
            var req = new RestRequest("/update_tables_status.php")
                .AddParameter("table_status", tables.table_status)
                .AddParameter("table_date", tables.table_date)
                .AddParameter("table_time", tables.table_time)
                .AddParameter("table_id", tables.table_id);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

    }
}
