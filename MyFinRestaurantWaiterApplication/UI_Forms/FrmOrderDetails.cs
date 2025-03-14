using System.Data;
using System.Linq;
using System.Windows.Forms;
using MyFinCassa.Model;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmOrderDetails : Form
    {
        public FrmOrderDetails(Order order)
        {
            InitializeComponent();

            InitForm(order);
        }

        private async void InitForm(Order order)
        {
            BindingSource bs = new BindingSource();

            var details = await new OrderDetails().OnSelectSubOrderDetailsAsync(order.order_main, order.order_sub);
            var types = await new Type().OnLoadAsync();

            foreach (var i in details)
            {
                i.product = await new Product().OnSelectAsync(i.details_prod);
                i.product.type = types.Where(u => u.type_id == i.product.prod_value).FirstOrDefault();
                bs.Add(i);
            }
            dgvMain.DataSource = bs;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
