using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using MyFinCassa.UC;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmCashe : Form
    {
        public FrmCashe(Order order, Hall hall = null, Tables table = null, int delivery = (int)EnumOrderType.Default)
        {
            InitializeComponent();
            var userControl = new UC_PageCasheRestraunt(this, order, hall, table, delivery)
            {
                Dock = DockStyle.Fill
            };
            casheContainer.Controls.Clear();
            casheContainer.Controls.Add(userControl);

            //GridPrincipal.Children.Clear();
            //GridPrincipal.Children.Add(new PageCashe(this, order, hall, table, delivery));
        }
    }
}