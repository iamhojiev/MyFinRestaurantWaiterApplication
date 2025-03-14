using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.WinForms;
using MyFinCassa.Helper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFinCassa.UC
{
    public partial class MyButton : UserControl
    {
        private Color blue = Color.RoyalBlue;
        private Color mediumGreen = Color.MediumSeaGreen;
        private Color darkGreen = Color.FromArgb(0, 105, 74);

        public MyButton(EnumMyButtonType buttonType)
        {
            InitializeComponent();
            SetButtonColor(buttonType);
        }

        private void SetButtonColor(EnumMyButtonType buttonType)
        {
            switch (buttonType)
            {
                case EnumMyButtonType.Blue:
                    btn.FillColor = blue;
                    break;
                case EnumMyButtonType.MediumGreen:
                    btn.FillColor = mediumGreen;
                    break;
                case EnumMyButtonType.DarkGreen:
                    btn.FillColor = darkGreen;
                    break;
            }
        }

        public Guna2Button Button { get { return btn; } }
    }
}
