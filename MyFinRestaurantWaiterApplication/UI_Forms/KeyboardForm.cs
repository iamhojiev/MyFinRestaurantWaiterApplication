using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyFinCassa.UI_Forms
{
    public partial class KeyboardForm : Form
    {
        public event Action<string> KeyPressed;
        private bool isCapsLock = true; // Переменная для отслеживания состояния Caps Lock

        #region [Mouse Form Drag]
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

        private Point numpadLocation;
        private Point keyboardLocation;
        private bool isNumpad;

        public KeyboardForm()
        {
            InitializeComponent();

            // Подписка на события мыши
            MouseDown += MyForm_MouseDown;
            keyboardPanel.MouseDown += MyForm_MouseDown;
            numPanel.MouseDown += MyForm_MouseDown;
        }

        public void SetNumPad()
        {
            isNumpad = true;
            numPanel.Visible = true;
            keyboardPanel.Visible = false;
            Size = new Size(235, 295);

            PositionFormIfNeeded(numpadLocation);
        }

        public void SetKeyboard()
        {
            isNumpad = false;
            numPanel.Visible = false;
            keyboardPanel.Visible = true;
            Size = new Size(700, 320);

            PositionFormIfNeeded(keyboardLocation);
        }

        public void MyHide()
        {
            Hide();
            if (isNumpad)
                numpadLocation = Location;
            else
                keyboardLocation = Location;
        }

        private void PositionFormIfNeeded(Point location)
        {
            if (location.IsEmpty)
                PositionForm(this);
            else
                Location = location;
        }

        private void PositionForm(Form form)
        {
            // Получаем размеры экрана
            var screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            var screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // Вычисляем координаты для размещения формы по центру внизу
            int x = (screenWidth - form.Width) / 2;
            int y = screenHeight - form.Height - 10; // Отступ от нижней части экрана

            // Устанавливаем положение формы и показываем ее
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(x, y);
        }

        private void Key_Click(object sender, EventArgs e)
        {
            OnKeyPressed(((Button)sender).Text);
        }

        private void OnKeyPressed(string key)
        {
            KeyPressed?.Invoke(key);
        }

        private void CapsLock_CLick(object sender, EventArgs e)
        {
            ToggleCapsLock();
        }

        private void ToggleCapsLock()
        {
            isCapsLock = !isCapsLock; // Переключаем состояние Caps Lock
            UpdateKeyboardLayout(); // Обновляем текст кнопок
        }

        private void UpdateKeyboardLayout()
        {
            UpdateKeyboardLayoutRecursive(this);
        }

        private void UpdateKeyboardLayoutRecursive(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button btn && btn.Text.Length == 1) // Если это кнопка с буквой
                {
                    btn.Text = isCapsLock ? btn.Text.ToUpper() : btn.Text.ToLower(); // Изменяем регистр в зависимости от состояния Caps Lock
                }
                else if (control.HasChildren) // Если у контрола есть дочерние элементы
                {
                    // Рекурсивно вызываем метод для дочернего контрола
                    UpdateKeyboardLayoutRecursive(control);
                }
            }
        }
    }
}