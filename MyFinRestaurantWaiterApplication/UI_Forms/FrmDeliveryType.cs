using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MyFinCassa.Helper;
using MyFinCassa.Model;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmDeliveryType : Form
    {
        private List<Delivery> deliveries;
        public Hall selectedHall { get; private set; }
        public Tables selectedTable { get; private set; }

        public FrmDeliveryType()
        {
            InitializeComponent();

            InitForm();
        }

        private async void InitForm()
        {
            deliveries = await new Delivery().OnLoadAsync();
            var currency = await new Currency().OnGetCurrencyValueAsync();

            txtDelivery1.Text = $"{deliveries[0].delivery_name}\n{deliveries[0].delivery_price} {currency}";
            txtDelivery1Info.Text = deliveries[0].delivery_desc;

            txtDelivery2.Text = $"{deliveries[1].delivery_name}\n{deliveries[1].delivery_price} {currency}";
            txtDelivery2Info.Text = deliveries[1].delivery_desc;

            txtDelivery3.Text = $"{deliveries[2].delivery_name}\n{deliveries[2].delivery_price} {currency}";
            txtDelivery3Info.Text = deliveries[2].delivery_desc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                btnClose.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Delivery1_Click(object sender, EventArgs e)
        {
            AcceptDelivery(deliveries[0]);
        }

        private void Delivery2_Click(object sender, EventArgs e)
        {
            AcceptDelivery(deliveries[1]);
        }

        private void Delivery3_Click(object sender, EventArgs e)
        {
            AcceptDelivery(deliveries[2]);

        }

        private void AcceptDelivery(Delivery delivery)
        {
            var id = delivery.delivery_id *= -1;
            var hall = new Hall()
            {
                hall_id = id,
                hall_name = delivery.delivery_name,
                hall_price = delivery.delivery_price,
            };
            var table = new Tables()
            {
                table_id = id,
                table_hall_id = id,
                table_name = delivery.delivery_name,
            };

            selectedHall = hall;
            selectedTable = table;

            DialogResult = DialogResult.OK;
        }

        private void btnDelivery3_MouseEnter(object sender, EventArgs e)
        {
            Guna2GradientPanel clickedPanel = FindGradientPanel((Control)sender);
            clickedPanel.FillColor = Color.FromArgb(135, 206, 235);
            clickedPanel.FillColor2 = Color.FromArgb(135, 206, 235);
            clickedPanel.Size = new Size(clickedPanel.Width + 6, clickedPanel.Height + 6);
            clickedPanel.Location = new Point(clickedPanel.Location.X - 3, clickedPanel.Location.Y - 3);
        }

        private void btnDelivery3_MouseLeave(object sender, EventArgs e)
        {
            Guna2GradientPanel clickedPanel = FindGradientPanel((Control)sender);
            clickedPanel.FillColor = Color.LightBlue;
            clickedPanel.FillColor2 = Color.LightBlue;
            clickedPanel.Size = new Size(clickedPanel.Width - 6, clickedPanel.Height - 6);
            clickedPanel.Location = new Point(clickedPanel.Location.X + 3, clickedPanel.Location.Y + 3);
        }

        private void btnDelivery3_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2GradientPanel clickedPanel = FindGradientPanel((Control)sender);

            clickedPanel.FillColor = Color.CadetBlue;
            clickedPanel.FillColor2 = Color.CadetBlue;
            clickedPanel.Size = new Size(clickedPanel.Width - 6, clickedPanel.Height - 6);
            clickedPanel.Location = new Point(clickedPanel.Location.X + 3, clickedPanel.Location.Y + 3);
            // 173, 203, 255
        }

        private Guna2GradientPanel FindGradientPanel(Control control)
        {
            if (control == null)
                return null;

            // Проверяем, является ли текущий контрол UserControl
            if (control is Guna2GradientPanel gradientPanel)
                return gradientPanel;

            // Рекурсивно ищем родительский UserControl
            return FindGradientPanel(control.Parent);
        }
    }
}
