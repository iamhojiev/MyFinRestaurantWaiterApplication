using Newtonsoft.Json;
using MyFinCassa.Database;
using RestSharp;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class User
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public int user_role { get; set; }
        public int user_kitchen { get; set; }
        public double user_salary { get; set; }
        public int user_salary_type { get; set; }
        public string user_last_payment { get; set; }
        public double user_earnings { get; set; }
        public double user_paid { get; set; }
        public double user_bonus { get; set; }
        public double user_fine { get; set; }

        public List<Shift> shift { get; set; }
        public Role role { get; set; }
        public List<Order> order { get; set; }

        public double UserSumma { get { return user_earnings + user_bonus - user_fine; } }
        public double UserBalance { get { return UserSumma - user_paid; } }
        public string UserRoleName { get { return role?.role_name; } }


        private static RestClient client = new RestClient(DataSQL.URL + @"/user");

        public async Task<User> OnSelectUserAsync(int id)
        {
            var req = new RestRequest("/select_user.php")
                .AddParameter("user_id", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<User>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<User> OnSelectPasswordAsync(string password)
        {
            var req = new RestRequest("/select_password_user.php")
                .AddParameter("user_password", password);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<User>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<bool> OnUpdateAsync(User user)
        {
            var req = new RestRequest("/update_user.php")
                .AddParameter("user_name", user.user_name)
                .AddParameter("user_password", user.user_password)
                .AddParameter("user_role", user.user_role)
                .AddParameter("user_earnings", user.user_earnings)
                .AddParameter("user_paid", user.user_paid)
                .AddParameter("user_bonus", user.user_bonus)
                .AddParameter("user_fine", user.user_fine)
                .AddParameter("user_salary", user.user_salary)
                .AddParameter("user_salary_type", user.user_salary_type)
                .AddParameter("user_last_payment", user.user_last_payment)
                .AddParameter("user_kitchen", user.user_kitchen)
                .AddParameter("user_id", user.user_id);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<List<User>> OnAllUserAsync(bool superAdmin = false)
        {
            var req = superAdmin
                ? new RestRequest("/load_all.php")
                : new RestRequest("/all_workers.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<User>(res.Content);

            return source;
        }

        public async Task<bool> OnMigrate()
        {
            var req = new RestRequest("/migrate.php");

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public override string ToString()
        {
            return user_name;
        }
    }
}
