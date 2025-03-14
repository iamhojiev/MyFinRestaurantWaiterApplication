using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;

namespace MyFinCassa.UI_Forms
{
    public partial class AddClient : Form
    {
        private KeyboardForm keyboardForm;
        private TextBox activeTextBox;
        private TextBox[] textBoxes;

        public AddClient()
        {
            InitializeComponent();
            InitializeTextBoxes();
            SetFocus();
        }

        private void InitializeTextBoxes()
        {
            // Сохраняем все текстовые поля в массив
            textBoxes = new[] { txtName, txtAddress, txtNumber };
            foreach (var textBox in textBoxes)
            {
                textBox.GotFocus += SetActiveTextBox;
            }
        }

        private void SetFocus()
        {
            txtName.Focus();
            txtName.Select();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            // Отключаем кнопку на время выполнения
            btnSave.Enabled = false;

            try
            {
                if (AreFieldsValid())
                {
                    var client = new Client
                    {
                        client_name = txtName.Text,
                        client_address = txtAddress.Text,
                        client_phone = txtNumber.Text,
                    };

                    bool result = await SaveClientAsync(client);

                    if (result)
                    {
                        Dialog.Info("Данные успешно добавлены!");
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    HighlightEmptyFields();
                    Dialog.Error("Заполните все обязательные поля!");
                }
            }
            catch (Exception ex)
            {
                Dialog.Error($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                btnSave.Enabled = true; // Включаем кнопку
            }
        }

        private bool AreFieldsValid()
        {
            // Проверяем, заполнены ли все текстовые поля
            return textBoxes.All(t => !string.IsNullOrWhiteSpace(t.Text));
        }

        private void HighlightEmptyFields()
        {
            // Подсвечиваем пустые поля
            foreach (var textBox in textBoxes)
            {
                textBox.BackColor = string.IsNullOrWhiteSpace(textBox.Text) ? System.Drawing.Color.LightCoral : System.Drawing.Color.White;
            }
        }

        private async Task<bool> SaveClientAsync(Client client)
        {
            // Обработка сохранения клиента
            return await new Client().OnInsertAsync(client);
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
                keyboardForm = null;
            }
        }

        private void KeyPressedHandler(string key)
        {
            if (activeTextBox == null) return;

            if (key.Length == 1)
            {
                activeTextBox.AppendText(key);
            }
            else if (key == "Space")
            {
                activeTextBox.AppendText(" ");
            }
            else if (key == "<-" && activeTextBox.Text.Length > 0)
            {
                activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1);
            }
        }


        private void BtnClose_Click(object sender, EventArgs e)
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

            if (keyData == Keys.Enter)
            {
                btnSave.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            ShowKeyboard();
        }

        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            HideKeyboard();
        }

        private void SetActiveTextBox(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
        }
    }
}
