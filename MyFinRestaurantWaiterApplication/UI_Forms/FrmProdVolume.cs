using System;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmProdVolume : Form
    {
        public double Volume { get; private set; }
        private KeyboardForm keyboardForm;
        private bool isFirstInput = true;

        public FrmProdVolume(Product prod = null)
        {
            InitializeComponent();
            SetupVolumeTextBox();
        }

        private void SetupVolumeTextBox()
        {
            txtVolume.Text = "1";
            txtVolume.Focus();
            txtVolume.SelectAll();
            txtVolume.KeyDown += TxtVolume_KeyDown;
            txtVolume.KeyPress += TextBox_KeyPress;
        }

        private void TxtVolume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }
        }

        private void ShowKeyboard()
        {
            keyboardForm = KeyboardManager.ShowNumpad();
            keyboardForm.KeyPressed += KeyPressedHandler;
        }

        private void HideKeyboard()
        {
            if (keyboardForm != null)
            {
                keyboardForm.KeyPressed -= KeyPressedHandler;
                KeyboardManager.HideKeyboard();
            }
        }

        private void KeyPressedHandler(string key)
        {
            if (isFirstInput)
            {
                txtVolume.Text = key;
                isFirstInput = false;
                return;
            }
            if (key.Length == 1)
            {
                txtVolume.AppendText(key);
            }
            else if (key == "<-")
            {
                if (txtVolume.Text.Length > 0)
                {
                    txtVolume.Text = txtVolume.Text.Substring(0, txtVolume.Text.Length - 1);
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtVolume.Text, out double v))
            {
                Volume = v;
                DialogResult = DialogResult.OK;
            }
            else
            {
                Dialog.Error("Ошибка ввода!");
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // Заменяем введённый символ на десятичный разделитель текущей культуры
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmProdVolume_Load(object sender, EventArgs e)
        {
            ShowKeyboard();
            CenterForm();
        }

        private void FrmProdVolume_FormClosing(object sender, FormClosingEventArgs e)
        {
            HideKeyboard();
        }

        private void CenterForm()
        {
            var screen = Screen.FromControl(this);
            var screenBounds = screen.WorkingArea;
            var formBounds = Bounds;

            int x = (screenBounds.Width - formBounds.Width) / 2;
            int y = (screenBounds.Height - formBounds.Height) / 2 - 120; // Adjust the value to move the form up

            Location = new System.Drawing.Point(x, y);
        }
    }
}
