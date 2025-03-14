using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using MyFinCassa.Model;
using MyFinCassa.Properties;
using MyFinCassa.UC;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmGuestCount : Form
    {

        public FrmGuestCount()
        {
            InitializeComponent();
        }

        public void Init(Tables table)
        {
            CreateTableLayoutGroup(this, table.table_place);
        }

        public void CreateTableLayoutGroup(Control parent, int userControlCount)
        {
            // Проверяем, что количество usercontrol больше нуля
            if (userControlCount <= 0)
            {
                return;
            }
            int maxCol = 2;
            if (userControlCount > 4) maxCol = 3;
            else if (userControlCount > 6) maxCol = 4;

            ResetTableLayout();

            int rowCount = (userControlCount - 1) / maxCol + 1; // округляем вверх
            int columnCount = Math.Min(userControlCount, maxCol); // не больше трех
                                                                  // Задаем количество строк и столбцов
            tlg.RowCount = rowCount;
            tlg.ColumnCount = columnCount;
            // Задаем размеры строк и столбцов в процентах
            for (int i = 0; i < rowCount; i++)
            {
                tlg.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rowCount));
            }
            for (int i = 0; i < columnCount; i++)
            {
                tlg.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount));
            }

            MyButton myBtn;
            for (int j = 0; j < userControlCount; j++)
            {
                myBtn = new MyButton(Helper.EnumMyButtonType.DarkGreen);
                myBtn.Dock = DockStyle.Fill;
                myBtn.Button.Click += Button_Click;
                myBtn.Button.Text = $"{j + 1}";

                int row = j / maxCol; // целочисленное деление
                int column = j % maxCol; // остаток от деления
                tlg.Controls.Add(myBtn, column, row);
            }
        }

        private void ResetTableLayout()
        {
            tlg.Controls.Clear();
            tlg.ColumnStyles.Clear();
            tlg.RowStyles.Clear();
            tlg.ColumnCount = 0;
            tlg.RowCount = 0;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                Settings.Default.guest_count = Convert.ToInt32(button.Text);
                Settings.Default.Save();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
