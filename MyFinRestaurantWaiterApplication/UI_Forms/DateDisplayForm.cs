using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyFinCassa.UI_Forms
{
    public partial class DateDisplayForm : Form
    {
        private Label labelDateTime;
        private Timer fadeTimer;
        private bool fadingIn;

        private readonly Dictionary<string, string> DaysOfWeekShort = new Dictionary<string, string>
        {
            { "понедельник", "Пн" },
            { "вторник", "Вт" },
            { "среда", "Ср" },
            { "четверг", "Чт" },
            { "пятница", "Пт" },
            { "суббота", "Сб" },
            { "воскресенье", "Вс" }
        };

        private readonly Dictionary<string, string> MonthsShort = new Dictionary<string, string>
        {
            { "январь", "янв" },
            { "февраль", "фев" },
            { "март", "мар" },
            { "апрель", "апр" },
            { "май", "май" },
            { "июнь", "июн" },
            { "июль", "июл" },
            { "август", "авг" },
            { "сентябрь", "сен" },
            { "октябрь", "окт" },
            { "ноябрь", "ноя" },
            { "декабрь", "дек" }
        };

        public DateDisplayForm()
        {
            InitializeComponent();
            InitializeDateTimeDisplay();
        }

        private void InitializeDateTimeDisplay()
        {
            // Настройка основного Label
            labelDateTime = new Label
            {
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 48, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                AutoSize = true
            };
            this.Controls.Add(labelDateTime);

            // Установка первичного текста
            UpdateDateTimeText();

            // Размещение в центре
            CenterLabel();

            // Timer для прозрачности
            fadeTimer = new Timer
            {
                Interval = 50 // 500 ms для плавного "мигания"
            };
            fadeTimer.Tick += FadeEffect;

            // Запуск цикла мигания
            fadingIn = true;
            fadeTimer.Start();
        }

        private void UpdateDateTimeText()
        {
            var now = DateTime.Now;

            // Получаем полные названия дня недели и месяца
            string fullDayOfWeek = now.ToString("dddd");
            string fullMonth = now.ToString("MMMM");

            // Заменяем на сокращённые версии
            string shortDayOfWeek = DaysOfWeekShort.ContainsKey(fullDayOfWeek.ToLower())
                ? DaysOfWeekShort[fullDayOfWeek.ToLower()]
                : fullDayOfWeek;

            string shortMonth = MonthsShort.ContainsKey(fullMonth.ToLower())
                ? MonthsShort[fullMonth.ToLower()]
                : fullMonth;

            // Формируем текст
            labelDateTime.Text = $"{shortDayOfWeek}, {now:dd} {shortMonth} {now:yyyy HH:mm}";
        }

        private void FadeEffect(object sender, EventArgs e)
        {
            // Изменение яркости цвета текста
            Color currentColor = labelDateTime.ForeColor;
            int step = 10; // Шаг изменения цвета (чем больше, тем быстрее)

            if (fadingIn)
            {
                // Увеличиваем интенсивность белого (переход от черного к белому)
                int red = Math.Min(currentColor.R + step, 255);
                int green = Math.Min(currentColor.G + step, 255);
                int blue = Math.Min(currentColor.B + step, 255);

                labelDateTime.ForeColor = Color.FromArgb(red, green, blue);

                if (red == 255 && green == 255 && blue == 255)
                {
                    fadingIn = false;
                }
            }
            else
            {
                // Уменьшаем интенсивность (переход от белого к черному)
                int red = Math.Max(currentColor.R - step, 0);
                int green = Math.Max(currentColor.G - step, 0);
                int blue = Math.Max(currentColor.B - step, 0);

                labelDateTime.ForeColor = Color.FromArgb(red, green, blue);

                if (red == 0 && green == 0 && blue == 0)
                {
                    fadingIn = true;
                    UpdateDateTimeText(); // Обновляем текст при каждом полном исчезновении
                }
            }
        }

        private void CenterLabel()
        {
            labelDateTime.Location = new Point(
                (this.ClientSize.Width - labelDateTime.Width) / 2,
                (this.ClientSize.Height - labelDateTime.Height) / 2
            );
        }
    }
}
