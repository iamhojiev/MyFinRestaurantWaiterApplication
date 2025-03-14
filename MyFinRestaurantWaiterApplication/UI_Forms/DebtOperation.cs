using MyFinCassa.Helper;
using MyFinCassa.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyFinCassa.UI_Forms
{
    public partial class DebtOperation : Form
    {
        //private double debtSumma;
        public DebtOperation(double summa)
        {
            InitializeComponent();

            txtPrice.Text = summa.ToString("N2");

            InitComboBox();
        }

        private async void InitComboBox()
        {
            var clients = new List<Client>
            {
                new Client { client_id = -1, client_name = "#Добавить нового клиента" },
            };
            clients.AddRange(await new Client().OnLoadAsync());

            cmbClient.DataSource = clients;
            cmbClient.DisplayMember = "client_name";
            cmbClient.ValueMember = "client_id";
            cmbClient.SelectedIndex = -1;
            cmbClient.SelectedIndexChanged += cmbClient_SelectedIndexChanged;

            cmbClient.Focus();
            cmbClient.Select();
        }

        private async void UpdateComboBox()
        {
            var clients = new List<Client>
            {
                new Client { client_id = -1, client_name = "#Добавить нового клиента" },
            };
            clients.AddRange(await new Client().OnLoadAsync());

            cmbClient.SelectedIndexChanged -= cmbClient_SelectedIndexChanged;
            cmbClient.DataSource = clients;
            cmbClient.DisplayMember = "client_name";
            cmbClient.ValueMember = "client_id";
            cmbClient.SelectedIndexChanged += cmbClient_SelectedIndexChanged;
        }


        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedIndex != -1)
            {
                var index = Convert.ToInt32(cmbClient.SelectedValue);
                var summa = Convert.ToDouble(txtPrice.Text);
                var selectedClient = await new Client().OnSelectAsync(index);
                selectedClient.client_debt += summa;

                if (await new Client().OnUpdateAsync(selectedClient))
                {
                    Dialog.Info("Долг успешно оформлен!");
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClient.SelectedIndex == 0)
            {
                AddClient addClient = new AddClient();
                if (addClient.ShowDialog() == DialogResult.OK)
                {
                    UpdateComboBox();
                    var lastClient = await new Client().OnSelectLastAsync();
                    cmbClient.SelectedValue = lastClient.client_id;
                }
                else
                {
                    cmbClient.SelectedIndex = -1;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                btnClose.PerformClick();
                return true;
            }

            if (keyData == Keys.Enter)
            {
                btnSave.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
