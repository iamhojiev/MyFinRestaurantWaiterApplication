using System.Windows.Forms;

namespace MyFinCassa.Helper
{

    // Файл Globals.cs
    public static class Globals
    {
        // Глобальный делегат
        public delegate void UserControlEventHandler(UserControl userControl);
        public delegate void QuitEventHandler();

        // Глобальное событие
        public static event UserControlEventHandler UserControlEvent;
        public static event QuitEventHandler QuitEvent;

        // Метод для вызова события
        public static void SetUserControl(UserControl userControl)
        {
            UserControlEvent?.Invoke(userControl); 
        }

        public static void Exit()
        {
            QuitEvent?.Invoke();
        }
    }
}
