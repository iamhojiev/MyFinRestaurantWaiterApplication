using MyFinCassa.Helper;
using MyFinCassa.Model;
using System;
using System.Windows.Forms;
using MyFinCassa.Properties;
using System.Threading.Tasks;

namespace MyFinCassa
{
    public partial class PageAuthorization : Form
    {
        public PageAuthorization()
        {
            InitializeComponent();
            InitializeFormAsync();
        }

        private void InitializeFormAsync()
        {
            InitCassaName();
            InitDateLabel();
            txtPass.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin.PerformClick();
                }
            };

            txtPass.Focus();
            txtPass.Select();
            txtPass.SelectAll();
        }

        private async void InitCassaName()
        {
            var myCassa = await new Cassa().OnSelectCassaAsync(Settings.Default.mycassa_id);
            lblCassaName.Text = myCassa.cassa_name;
        }

        public void Reinit()
        {
            this.Show();
            txtPass.Focus();
            txtPass.Select();
            txtPass.SelectAll();
        }

        private void InitDateLabel()
        {
            var dateTime = DateTime.Now;
            string dateToday = $"{dateTime.Day}.{dateTime.Month:D2}.{dateTime.Year}";
            string nowTime = $"{dateTime.Hour:D2}:{dateTime.Minute:D2}";
            string weekDay = WeekParse(dateTime.DayOfWeek.ToString());
            lblDate.Text = dateToday + " / " + nowTime + Environment.NewLine + weekDay;
        }

        private string WeekParse(string week)
        {
            switch (week)
            {
                case "Monday":
                    return "Понедельник";
                case "Tuesday":
                    return "Вторник";
                case "Wednesday":
                    return "Среда";
                case "Thursday":
                    return "Четверг";
                case "Friday":
                    return "Пятница";
                case "Saturday":
                    return "Суббота";
                case "Sunday":
                    return "Воскресенье";
                default:
                    return "";
            }
        }
        //private string WeekParse(string week)
        //{
        //    switch (week)
        //    {
        //        case "Monday":
        //            return "Душанбе";
        //        case "Tuesday":
        //            return "Сешанбе";
        //        case "Wednesday":
        //            return "Чоршанбе";
        //        case "Thursday":
        //            return "Панҷшанбе";
        //        case "Friday":
        //            return "Ҷумъа";
        //        case "Saturday":
        //            return "Шанбе";
        //        case "Sunday":
        //            return "Якшанбе";
        //        default:
        //            return "";
        //    }
        //}

        private async void LogIn_Click(object sender, EventArgs e)
        {
            var pass = txtPass.Text;

            var user = await new User().OnSelectPasswordAsync(pass);

            if (user != null)
            {
                var shift = await new Shift().OnSelectShiftOpenAsync(user.user_id);

                if (shift == null)
                    Settings.Default.change_id = 0;
                else
                    Settings.Default.change_id = shift.shift_id;

                Settings.Default.Save();

                if (Settings.Default.change_id == 0)
                {
                    //   var userId = Settings.Default.user_id;
                    var el = new Shift()
                    {
                        shift_date_open = MyDate.DateFormat(),
                        shift_user_id = user.user_id,
                        shift_status = (int)EnumShift.Open,
                        shift_date_close = ""
                    };
                    if (await new Shift().OnInsertAsync(el))
                    {
                        var _shift = await new Shift().OnSelectLastAsync();
                        Settings.Default.change_id = _shift.shift_id;
                    }
                }

                txtPass.Text = "";

                Settings.Default.user_id = user.user_id;
                Settings.Default.user_type = user.user_role;
                Settings.Default.Save();

                Form mainForm = CreateMainForm();
                mainForm.Owner = this;
                mainForm.Show();
                Hide();

            }
            else
            {
                await Debug.DebugInsertAsync(string.Format("Неудачная попытка входа: Пароль: {0}", pass));
                Dialog.Error("Пароль введён неверно!");
                txtPass.Focus();
                txtPass.SelectAll();
            }
        }

        private Form CreateMainForm()
        {
#if Cafe
            return new CafeMainForm();
#else
                return new RestaurantMainForm();

#endif
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtPass.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPass.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPass.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPass.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPass.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPass.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPass.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPass.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPass.Text += '9';
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPass.Text += '0';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length > 0)
                txtPass.Text = txtPass.Text.Substring(0, txtPass.Text.Length - 1);
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
