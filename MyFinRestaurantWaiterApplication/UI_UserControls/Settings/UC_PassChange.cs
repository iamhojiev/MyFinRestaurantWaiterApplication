using System;
using System.Windows.Forms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using MyFinCassa.Properties;

namespace MyFinCassa.UC
{
    public partial class UC_PassChange : UserControl
    {
        public UC_PassChange()
        {
            InitializeComponent();
        }

        private async void BtnSavePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPass.Text) ||
                string.IsNullOrWhiteSpace(txtNewPass.Text) ||
                string.IsNullOrWhiteSpace(txtReloadPass.Text))
            {
                Dialog.Error("Все поля паролей должны быть заполнены!");
                return;
            }

            var user = new User();
            var myUser = await user.OnSelectUserAsync(Settings.Default.user_id);

            if (myUser == null)
            {
                Dialog.Error("Пользователь не найден!");
                return;
            }

            var check = await user.OnSelectPasswordAsync(txtNewPass.Text);
            if (check != null)
            {
                Dialog.Error("Пароль должен быть уникальным! Данный пароль уже существует!");
                return;
            }

            if (!string.Equals(myUser.user_password, txtOldPass.Text))
            {
                Dialog.Error("Неверно указан старый пароль!");
                return;
            }

            if (!string.Equals(txtNewPass.Text, txtReloadPass.Text))
            {
                Dialog.Error("Пароли не совпадают!");
                return;
            }

            myUser.user_password = txtNewPass.Text;

            if (await user.OnUpdateAsync(myUser))
            {
                Dialog.Info("Пароль успешно изменен!");
                ResetTextBoxes();
            }
            else
            {
                Dialog.Error("Ошибка при обновлении пароля!");
            }
        }

        private void ResetTextBoxes()
        {
            txtNewPass.Text = string.Empty;
            txtOldPass.Text = string.Empty;
            txtReloadPass.Text = string.Empty;
            txtOldPass.PlaceholderText = "Старый пароль";
            txtNewPass.PlaceholderText = "Новый пароль";
            txtReloadPass.PlaceholderText = "Повторите пароль";
        }
    }
}
