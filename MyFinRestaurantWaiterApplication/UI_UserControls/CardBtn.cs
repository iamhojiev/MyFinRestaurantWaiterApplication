using Guna.UI2.WinForms;
using System.Windows.Forms;


namespace MyFinCassa.UC
{
    public partial class CardBtn : UserControl
    {

        public CardBtn()
        {
            InitializeComponent();
        }

        public Guna2Button CardGunaButton { get { return btn; } }
        public PictureBox CardLogo { get { return picCardLogo; } }
    }
}


