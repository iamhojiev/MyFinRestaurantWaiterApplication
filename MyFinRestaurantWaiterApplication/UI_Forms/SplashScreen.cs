using MyFinCassa.Helper;
using MyFinCassa.Model;
using MyFinCassa.Properties;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinCassa.UI_Forms
{
    public partial class SplashScreen : Form
    {
        private readonly Random random = new Random();
        private bool isLicenseChecked = false; // Флаг для проверки лицензии

        private readonly int licenseCheckPoint; // Точка, на которой проверится лицензия

        public SplashScreen()
        {
            InitializeComponent();
            shadowForm.SetShadowForm(this);
            timerProgress.Start();
            licenseCheckPoint = random.Next(30, 70);

            InitVersionLabel();
            MigrateUserSettings();
            MigrateDb();
            InitMyCassa();
        }

        private async void InitMyCassa()
        {
            timerProgress.Stop();

            // Пытаемся загрузить выбранную кассу
            var myCassa = await new Cassa().OnSelectCassaAsync(Settings.Default.mycassa_id);

            // Если касса не найдена, предлагаем пользователю выбрать
            if (myCassa == null && !SelectCassa())
            {
                ShowError("Ошибка выбора кассы.");
            }

            timerProgress.Start();
        }

        private bool SelectCassa()
        {
            using (var cassaSelector = new CassaSelector())
            {
                if (cassaSelector.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.mycassa_id = cassaSelector.SelectedCassa.cassa_id;
                    Settings.Default.Save();
                    return true;
                }
            }
            return false;
        }

        private void InitVersionLabel()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version currentVersion = assembly.GetName().Version;
            txtVersion.Text = $"Версия {currentVersion}";
        }

        private void MigrateUserSettings()
        {
            if (Settings.Default.SettingsUpgraded == false)
            {
                Settings.Default.Upgrade(); // Переносим старые настройки
                Settings.Default.SettingsUpgraded = true;
                Settings.Default.Save(); // Сохраняем изменения
            }
        }

        private async void MigrateDb()
        {
            await new User().OnMigrate();
        }

        private async Task CheckLicenseAsync()
        {
            var myLicense = await new License().OnSelectAsync();
            if (myLicense == null)
            {
                ShowError("Лицензия не была найдена. Возможно, она истекла или отсутствует.");
                return;
            }

            if (!LicenseUtility.IsLicenseValid(myLicense, out string reason))
            {
                ShowError(reason);
            }
        }

        private void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка лицензии!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }

        private async void timerProgress_Tick(object sender, EventArgs e)
        {
            if (!isLicenseChecked && progresLoading.Value > licenseCheckPoint)
            {
                timerProgress.Stop();
                isLicenseChecked = true; // Отмечаем, что проверка уже прошла

                await CheckLicenseAsync();

                timerProgress.Start();
            }

            // Двигаем прогресс неравномерно
            if (progresLoading.Value < 100)
            {
                progresLoading.Value += random.Next(1, 5);
                timerProgress.Interval = random.Next(10, 100);
            }
            else
            {
                timerProgress.Stop();
                var window = new PageAuthorization();
                window.Show();
                Hide();
            }
        }
    }
}
