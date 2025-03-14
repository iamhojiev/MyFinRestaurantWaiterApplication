using System;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmOrderComment : Form
    {
        public string CommentText { get; private set; }
        public bool PendingClicked { get; private set; }
        public bool SaveClicked { get; private set; }

        private KeyboardForm keyboardForm;

        public FrmOrderComment(Product prod = null, string text = "")
        {
            InitializeComponent();
            InitializeForm(prod, text);
        }

        private void InitializeForm(Product prod, string text)
        {
            if (prod != null)
            {
                txtTittle.Text = $"Коментарии к блюду: {prod.prod_name}";
                BtnPending.Text = "Сохранить";
                BtnSave.Visible = false;
            }
            else
            {
                txtTittle.Text = "Коментарии к заказу";
            }

            if (!string.IsNullOrEmpty(text))
            {
                CommentText = text;
            }

            txtComment.Text = CommentText;
            txtComment.Focus();
            txtComment.SelectAll();
        }

        private void ShowKeyboard()
        {
            keyboardForm = KeyboardManager.ShowKeyboard();
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
            if (key.Length == 1)
            {
                txtComment.AppendText(key);
            }
            else if (key == "Space")
            {
                txtComment.AppendText(" ");
            }
            else if (key == "<-" && txtComment.Text.Length > 0)
            {
                txtComment.Text = txtComment.Text.Substring(0, txtComment.Text.Length - 1);
            }
        }

        private void BtnPending_Click(object sender, EventArgs e)
        {
            CommentText = txtComment.Text;
            PendingClicked = true;
            DialogResult = DialogResult.OK;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CommentText = txtComment.Text;
            SaveClicked = true;
            DialogResult = DialogResult.OK;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                BtnClose.PerformClick();
                return true;
            }

            if (keyData == Keys.Enter)
            {
                BtnPending.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FrmOrderComment_Load(object sender, EventArgs e)
        {
            ShowKeyboard();
            CenterForm();
        }

        private void FrmOrderComment_FormClosing(object sender, FormClosingEventArgs e)
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
