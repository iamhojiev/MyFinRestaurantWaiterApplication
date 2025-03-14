using MyFinCassa.UI_Forms;


namespace MyFinCassa.Helper
{
    public static class KeyboardManager
    {
        private static KeyboardForm _keyboard;

        public static KeyboardForm ShowKeyboard()
        {
            if (_keyboard == null || _keyboard.IsDisposed)
            {
                _keyboard = new KeyboardForm();
            }
            _keyboard.SetKeyboard();
            _keyboard.Show();
            return _keyboard;
        }

        public static KeyboardForm ShowNumpad()
        {
            if (_keyboard == null || _keyboard.IsDisposed)
            {
                _keyboard = new KeyboardForm();
            }
            _keyboard.SetNumPad();
            _keyboard.Show();
            return _keyboard;
        }

        public static void HideKeyboard()
        {
            _keyboard?.MyHide();
        }
    }
}
