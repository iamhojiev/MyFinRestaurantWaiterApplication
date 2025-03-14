using MyFinCassa.Properties;
using System.Windows.Forms;
using MyFinCassa.Model;
using MyFinCassa.Database;

namespace MyFinCassa.UI_UserControls.PageCashe
{
    public partial class CategoryButton : UserControl
    {
        public string CategoryName { get; private set; }

        public CategoryButton(Category category)
        {
            InitializeComponent();
            InitializeCategoryButton(category);
        }

        private void InitializeCategoryButton(Category category)
        {
            CategoryName = category.category_name;
            Button.Tag = CategoryName;
            Button.Text = CategoryName;

            var imageName = $"{CategoryName}{category.category_id}.png";
            var image = ImageServerIO.GetImage(imageName);
            Button.Image = image ?? Resources.cameraOf_small;
        }
    }
}
