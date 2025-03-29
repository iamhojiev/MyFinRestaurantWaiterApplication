using MyFinCassa.Database;
using MyFinCassa.Helper;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinCassa.Model
{
    public class Shift
    {
        public int shift_id { get; set; }
        public string shift_date_open { get; set; }
        public string shift_date_close { get; set; }
        public int shift_user_id { get; set; }
        public int shift_status { get; set; }

        public User user { get; set; }
        public string GetUserName { get { return user?.user_name; } }

        private static RestClient client = new RestClient(DataSQL.URL + @"/shift");

        public string OnStatus
        {
            get
            {
                return shift_status == (int)EnumShift.Close ? shift_date_close : "Смена открыта";
            }
        }

        public List<Order> shiftOrders;

        public int OrdersCount => shiftOrders?.Count ?? 0;
        public double OrdersSum => shiftOrders?.Sum(u => u.order_price) ?? 0;

        public async Task LoadOrdersAsync()
        {
            shiftOrders = await new Order().OnLoadShiftAsync(shift_id);
        }

        public async Task<double> GetWaiterEarningsAsync()
        {
            if (shiftOrders == null)
            {
                await LoadOrdersAsync();
            }

            var waiterOrders = shiftOrders.Where(or => or.order_delivery == (int)EnumOrderType.Default);
            return waiterOrders.Sum(u => u.order_price_waiter);
        }

        public async Task<List<Shift>> OnLoadAsync()
        {
            var req = new RestRequest("/load_shift.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Shift>(res.Content);

            return source;
        }

        public async Task<List<Shift>> LoadUserShiftsAsync(int userId)
        {
            var req = new RestRequest("/load_user_shifts.php")
                .AddParameter("user_id", userId);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Shift>(res.Content);

            return source;
        }

        public async Task<Shift> OnSelectAsync(int id)
        {
            var req = new RestRequest("/select_shift.php")
                .AddParameter("shift_id", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Shift>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<Shift> OnSelectShiftOpenAsync(int id)
        {
            var req = new RestRequest("/select_user_shift.php")
                .AddParameter("shift_user_id", id);

            var res = await client.PostAsync(req);

            var source = DataSQL.Deserialize<Shift>(res.Content);

            return source.Count > 0 ? source[0] : null;
        }

        public async Task<Shift> OnSelectLastAsync()
        {
            var req = new RestRequest("/select_last_shift.php");

            var res = await client.GetAsync(req);

            var source = DataSQL.Deserialize<Shift>(res.Content);

            return source[0];
        }

        public async Task<bool> OnUpdateAsync(Shift shift)
        {
            var req = new RestRequest("/update_shift.php")
                .AddParameter("shift_id", shift.shift_id)
                .AddParameter("shift_user_id", shift.shift_user_id)
                .AddParameter("shift_status", shift.shift_status)
                .AddParameter("shift_date_open", shift.shift_date_open)
                .AddParameter("shift_date_close", shift.shift_date_close);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

        public async Task<bool> OnInsertAsync(Shift shift)
        {
            var req = new RestRequest("/insert_shift.php")
                .AddParameter("shift_user_id", shift.shift_user_id)
                .AddParameter("shift_status", shift.shift_status)
                .AddParameter("shift_date_open", shift.shift_date_open)
                .AddParameter("shift_date_close", shift.shift_date_close);

            var res = await client.PostAsync(req);

            return res.IsSuccessful;
        }

    }
}
