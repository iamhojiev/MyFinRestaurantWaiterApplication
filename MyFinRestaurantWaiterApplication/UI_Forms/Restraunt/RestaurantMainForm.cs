using System;
using System.Windows.Forms;
using MyFinCassa.UC;
using MyFinCassa.Model;
using MyFinCassa.Helper;
using MyFinCassa.Properties;
using MyFinCassa.UI_UserControls.Cassa;

namespace MyFinCassa
{
    public partial class RestaurantMainForm : Form
    {
        private UC_Logs Logs;
        private UC_PassChange PassChange;
        private UC_WaiterStats WaiterStats;
        private UC_IncomingInfo IncomingInfo;
        private UC_Employee Employee;
        private UC_ShiftHistory ShiftHistory;
        private UC_CasheHistory CasheHistory;
        private UC_HallTableCategories HallTableCategories;
        private UC_Discount Discount;
        private UC_CassaInfo CassaInfo;
        private UC_ShiftChange ShiftChange;
        private UC_NewCassa MyCassa;
        private User myUser;

        public RestaurantMainForm()
        {
            InitializeComponent();
            InitUser();
            btnMainMenu.PerformClick();
            Globals.UserControlEvent += OnUserControlEvent;
            Globals.QuitEvent += OnQuit;
        }

        private async void InitUser()
        {
            var myUserID = Settings.Default.user_id;
            myUser = await new User().OnSelectUserAsync(myUserID);
            var myUserRole = myUser.user_role;
            ManageAccessByUser(myUserRole);
        }

        private void ManageAccessByUser(int myUserRole)
        {
            switch (myUserRole)
            {
                case (int)EnumUserRole.Admin:
                    {
                        break;
                    }
                case (int)EnumUserRole.Cashier:
                    {
                        btnLists.Visible = false;
                        btnLogs.Visible = false;
                        btnFinance.Visible = false;
                        btnStatistic.Visible = false;
                        btnCassaInfo.Visible = false;
                        btnSettings.Visible = false;
                        btnOperations.Visible = false;
                        break;
                    }
                case (int)EnumUserRole.Waiter:
                    {
                        btnLists.Visible = false;
                        btnLogs.Visible = false;
                        btnFinance.Visible = false;
                        btnStatistic.Visible = false;
                        btnCassaInfo.Visible = false;
                        btnSettings.Visible = false;
                        btnOperations.Visible = false;
                        // btnMainMenu.Visible = false;
                        break;
                    }
            }
        }

        private void OnUserControlEvent(UserControl userControl)
        {
            SetUserControl(userControl);
        }

        private void OnQuit()
        {
            // Application.Exit();
            ((PageAuthorization)Owner).Reinit();
            Hide();
        }

        public void SetUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            OnQuit();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            if (Logs == null)
                Logs = new UC_Logs();
            else
                Logs.UpdateGrid();
            SetUserControl(Logs);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (PassChange == null)
                PassChange = new UC_PassChange();
            SetUserControl(PassChange);
        }

        private void btnWaiterStatistic_Click(object sender, EventArgs e)
        {
            if (WaiterStats == null)
                WaiterStats = new UC_WaiterStats();
            SetUserControl(WaiterStats);
        }

        private void btnIncomingInfo_Click(object sender, EventArgs e)
        {
            if (IncomingInfo == null)
                IncomingInfo = new UC_IncomingInfo();
            SetUserControl(IncomingInfo);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (Employee == null)
                Employee = new UC_Employee();
            SetUserControl(Employee);
        }

        private async void btnShiftHistory_Click(object sender, EventArgs e)
        {
            if (ShiftHistory == null)
                ShiftHistory = new UC_ShiftHistory();
            await ShiftHistory.UpdateGrid();
            SetUserControl(ShiftHistory);
        }

        private async void btnCassaHistory_Click(object sender, EventArgs e)
        {
            if (CasheHistory == null)
                CasheHistory = new UC_CasheHistory();
            await CasheHistory.UpdateGridAsync();
            SetUserControl(CasheHistory);
        }

        private void btnHallTableCategories_Click(object sender, EventArgs e)
        {
            if (HallTableCategories == null)
                HallTableCategories = new UC_HallTableCategories();
            HallTableCategories.UpdateCurrentTab();
            SetUserControl(HallTableCategories);
        }

        private async void btnShift_Click(object sender, EventArgs e)
        {
            if (ShiftChange == null) ShiftChange = new UC_ShiftChange();
            await ShiftChange.UpdateTextAsync();
            SetUserControl(ShiftChange);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (Discount == null) Discount = new UC_Discount();
            SetUserControl(Discount);
        }

        private void btnCassa_Click(object sender, EventArgs e)
        {
            if (MyCassa == null) MyCassa = new UC_NewCassa();
            else MyCassa.CheckShiftStatus();
            SetUserControl(MyCassa);
        }

        private async void btnCassaInfo_Click(object sender, EventArgs e)
        {
            if (CassaInfo == null) CassaInfo = new UC_CassaInfo();
            else await CassaInfo.UpdateTextsAsync();
            SetUserControl(CassaInfo);
        }
    }
}
