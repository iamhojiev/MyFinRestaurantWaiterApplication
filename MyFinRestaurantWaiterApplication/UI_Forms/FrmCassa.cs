using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MyFinCassa.Helper;
using MyFinCassa.Model;
using MyFinCassa.UC;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmCassa : Form
    {
        public delegate void TableSelectedEventHandler(object sender, TableEventArgs e);
        public event TableSelectedEventHandler TableSelected;

        private List<Hall> halls;
       
        public FrmCassa()
        {
            InitializeComponent();
            InitHalls();
        }

        private async void InitHalls()
        {
            halls = await new Hall().OnLoadHallsAsync();

            TabPage tabPage;
            foreach (var i in halls)
            {
                tabPage = new TabPage(i.hall_name);
                tabControl.TabPages.Add(tabPage);
            }
            UpdateTable();
        }

        private async void UpdateTable()
        {
            var tabSelectedIndex = tabControl.SelectedIndex;
            var index = Convert.ToInt32(halls[tabSelectedIndex].hall_id);

            var tables = (await new Tables().OnLoadAsync()).Where(u => u.table_hall_id == index).ToList();
            TabPage currentTab = tabControl.SelectedTab;

            CreateTableLayoutGroup(tables, currentTab, tables.Count);
        }

        public async void CreateTableLayoutGroup(List<Tables> tables, Control parent, int userControlCount)
        {
            // Проверяем, что количество usercontrol больше нуля
            if (userControlCount <= 0)
            {
                return;
            }

            #region [Вычет строк и столбцов]
            if (!(Controls.Find(parent.Text, true).FirstOrDefault() is TableLayoutPanel tlg))
            {
                tlg = new TableLayoutPanel
                {
                    Name = parent.Text
                };
                int rowCount;
                int columnCount;

                if (userControlCount < 5)
                {
                    rowCount = 2;
                    columnCount = userControlCount;
                }
                else if (userControlCount <= 6)
                {
                    rowCount = 2;
                    columnCount = 3;
                }
                else if (userControlCount <= 8)
                {
                    rowCount = 2;
                    columnCount = 4;
                }
                else if (userControlCount <= 10)
                {
                    rowCount = 2;
                    columnCount = 5;
                }
                else if (userControlCount <= 12)
                {
                    rowCount = 3;
                    columnCount = 4;
                }
                else if (userControlCount <= 15)
                {
                    rowCount = 3;
                    columnCount = 5;
                }
                else if (userControlCount <= 20)
                {
                    rowCount = 4;
                    columnCount = 5;
                }
                else if (userControlCount < 25)
                {
                    rowCount = 4;
                    columnCount = 6;
                }
                else if (userControlCount <= 30)
                {
                    rowCount = 5;
                    columnCount = 6;
                }
                else if (userControlCount <= 36)
                {
                    rowCount = 6;
                    columnCount = 6;
                }
                else
                {
                    rowCount = (userControlCount - 1) / 6 + 1; // округляем вверх
                    columnCount = Math.Min(userControlCount, 6); // не больше 5'и
                }

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
                tlg.Dock = DockStyle.Fill;
                parent.Controls.Add(tlg);
            }
            else
            {
                tlg.Controls.Clear();
            }
            #endregion

            MyTable myTable;
            var tablesStatus = await new TableStatus().OnLoadAsync();
            for (int j = 0; j < tables.Count; j++)
            {
                var i = tables[j];
                i.hall = halls.Where(u => u.hall_id == i.table_hall_id).FirstOrDefault();
                i.tables_status = tablesStatus.Where(u => u.table_st_id == i.table_status).FirstOrDefault();
                myTable = new MyTable();
                myTable.btn.Text = $"Стол: #{i.table_name}\nМест: {i.table_place}";
                switch (i.table_status)
                {
                    case (int)EnumTablesStatus.Free:
                        myTable.btn.FillColor = Color.SeaGreen;
                        break;
                    case (int)EnumTablesStatus.Busy:
                        myTable.btn.FillColor = Color.FromArgb(152, 48, 48);

                        break;
                    case (int)EnumTablesStatus.Booked:
                        myTable.btn.FillColor = Color.FromArgb(36, 36, 36);
                        break;
                }
                myTable.Dock = DockStyle.Fill;
                myTable.btn.Tag = i;
                myTable.btn.Click += TableButton_Click;

                int row = j / tlg.ColumnCount; // целочисленное деление
                int column = j % tlg.ColumnCount; // остаток от деления
                tlg.Controls.Add(myTable, column, row);
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            if (((Guna2Button)sender).Tag is Tables myTable)
            {
                TableSelected?.Invoke(this, new TableEventArgs { SelectedTable = myTable });
                UpdateTable();
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}

