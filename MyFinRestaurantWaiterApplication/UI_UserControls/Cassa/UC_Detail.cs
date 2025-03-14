using MyFinCassa.Helper;
using MyFinCassa.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFinCassa.UI_UserControls.Cassa
{
    public partial class UC_Detail : UserControl
    {
        public UC_Detail(Product product)
        {
            InitializeComponent();

            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null");
            }

            txtName.Text = product.prod_name;
            txtTotal.Text = product.prod_total.ToString();

            switch ((EnumDetailsStatus)product.prod_status)
            {
                case EnumDetailsStatus.Ready:
                    txtTotal.BackColor = Color.DarkCyan;
                    break;
                case EnumDetailsStatus.NewOrder:
                    txtTotal.BackColor = Color.DarkGoldenrod;
                    break;
                case EnumDetailsStatus.Submited:
                    txtTotal.BackColor = Color.DimGray;
                    break;
                case EnumDetailsStatus.Return:
                    txtTotal.BackColor = Color.DarkRed;
                    break;
                default:
                    txtTotal.BackColor = Color.Transparent; // Default color if status is unknown
                    break;
            }

            txtName.AutoSize = true;
            // Затем установите размер UserControl равным размеру Label
            this.Size = new Size(txtName.Width + 30, this.Size.Height);
        }
    }
}