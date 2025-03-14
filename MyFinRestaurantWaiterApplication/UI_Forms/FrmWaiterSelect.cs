using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using MyFinCassa.UC;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmWaiterSelect : Form
    {
        public User SelectedWaiter { get; private set; }

        public FrmWaiterSelect()
        {
            InitializeComponent();
            InitWaiters();
        }

        private async void InitWaiters()
        {
            var user = new User();
            var waiters = (await user.OnAllUserAsync()).Where(u => u.user_role == (int)EnumUserRole.Waiter).ToList();
            CreateTableLayoutGroup(waiters, mainContainer, waiters.Count);
        }

        private void CreateTableLayoutGroup(List<User> waiters, Control parent, int userControlCount)
        {
            if (userControlCount <= 0) return;

            var tlg = new TableLayoutPanel
            {
                RowCount = (userControlCount - 1) / 5 + 1,
                ColumnCount = Math.Min(userControlCount, 5),
                Dock = DockStyle.Fill
            };

            for (int i = 0; i < tlg.RowCount; i++)
                tlg.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / tlg.RowCount));

            for (int i = 0; i < tlg.ColumnCount; i++)
                tlg.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / tlg.ColumnCount));

            parent.Controls.Add(tlg);

            for (int j = 0; j < waiters.Count; j++)
            {
                var waiter = waiters[j];
                var myButton = new MyButton(EnumMyButtonType.Blue)
                {
                    Dock = DockStyle.Fill,
                    Button = { Tag = waiter, Text = waiter.user_name }
                };
                myButton.Button.Click += WaiterButtonClick_Click;

                tlg.Controls.Add(myButton, j % 5, j / 5);
            }
        }

        private void WaiterButtonClick_Click(object sender, EventArgs e)
        {
            if (((Guna2Button)sender).Tag is User waiter)
            {
                SelectedWaiter = waiter;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
