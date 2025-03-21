using MyFinCassa.Properties;
using System.Windows.Forms;
using MyFinCassa.Model;
using MyFinCassa.Database;
using System.Drawing;

namespace MyFinCassa.UI_UserControls.PageCashe
{
    public partial class UC_ProductWidget : UserControl
    {
        public string Category { get; private set; }

        public UC_ProductWidget(Product product, string currency, string category)
        {
            InitializeComponent();
            Category = category;
            InitializeProductWidget(product, currency);
        }

        private void InitializeProductWidget(Product product, string currency)
        {
            Container.Tag = product;
            txtTitle.Tag = product;
            txtProdPrice.Tag = product;
            picProd.Tag = product;

            txtTitle.Text = product.prod_name;
            txtProdPrice.Text = $"{product.prod_price} {currency}/{product.type.type_name}";
            // txtProdPrice.Text = $"{product.prod_price}\n{currency}/{volume}";

            var imageName = $"{product.prod_name}{product.prod_id}.png";
            var image = ImageServerIO.GetImage(imageName);
            picProd.Image = image ?? Resources.cameraOf_high;
        }

        public void UpdateSelection(Product basketProduct)
        {
            bool isSelected = basketProduct != null;
            BackColor = isSelected ? Color.DarkSeaGreen : Color.White;
            txtCount.Visible = isSelected;

            if (isSelected)
            {
                txtCount.Text = $"x{basketProduct.prod_total}";
            }
        }
    }
}
