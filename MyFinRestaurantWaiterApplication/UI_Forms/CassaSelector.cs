
using MyFinCassa.Properties;
using System;
using System.Windows.Forms;
using MyFinCassa.Model;

namespace MyFinCassa.UI_Forms
{
    public partial class CassaSelector : Form
    {
        public Cassa SelectedCassa { get; set; }

        public CassaSelector()
        {
            InitializeComponent();
            InitComboBox();
        }

        private async void InitComboBox()
        {
            var cassa = await new Cassa().OnLoadAsync();
            cmbCassa.DataSource = cassa;
            cmbCassa.DisplayMember = "cassa_name";
            cmbCassa.ValueMember = "cassa_id";
            cmbCassa.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCassa.SelectedIndex != -1)
            {
                SelectedCassa = cmbCassa.SelectedItem as Cassa;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnSave.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
