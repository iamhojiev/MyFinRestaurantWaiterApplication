using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MyFinCassa.Model;
using System.Drawing;
using MyFinCassa.Helper;
using MyFinCassa.UC;

namespace MyFinCassa.UI_Forms
{
    public partial class FrmOrderSelectTable : Form
    {
        private List<Hall> halls;
        private FrmGuestCount formGuestsCount;

        public FrmOrderSelectTable()
        {
            InitializeComponent();
            InitHalls();
        }

        private async void InitHalls()
        {
            try
            {
                halls = await new Hall().OnLoadHallsAsync();

                foreach (var hall in halls)
                {
                    var tabPage = new TabPage(hall.hall_name);
                    tabControl.TabPages.Add(tabPage);
                }

                UpdateTable();
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка загрузки залов: {ex.Message}");
            }
        }

        private async void UpdateTable()
        {
            try
            {
                var tabSelectedIndex = tabControl.SelectedIndex;
                var hallId = halls[tabSelectedIndex].hall_id;
                var tables = (await new Tables().OnLoadAsync()).Where(t => t.table_hall_id == hallId).ToList();

                CreateTableLayoutGroup(tables, tabControl.SelectedTab, tables.Count);
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка обновления столиков: {ex.Message}");
            }
        }

        public async void CreateTableLayoutGroup(List<Tables> tables, Control parent, int userControlCount)
        {
            if (userControlCount <= 0) return;

            var tableStatusList = await new TableStatus().OnLoadAsync();
            //var tlg = parent.Controls.OfType<TableLayoutPanel>().FirstOrDefault() ?? new TableLayoutPanel
            //{
            //    Name = parent.Text,
            //    Dock = DockStyle.Fill
            //};

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

            foreach (var table in tables)
            {
                var hall = halls.FirstOrDefault(h => h.hall_id == table.table_hall_id);
                var tableStatus = tableStatusList.FirstOrDefault(ts => ts.table_st_id == table.table_status);

                var myTable = new MyTable
                {
                    Dock = DockStyle.Fill,
                    btn =
                    {
                        Text = $"Стол: #{table.table_name}\nМест: {table.table_place}",
                        Tag = table
                    }
                };

                switch (table.table_status)
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

                myTable.btn.Click += TableButton_Click;

                int row = tlg.Controls.Count / tlg.ColumnCount;
                int column = tlg.Controls.Count % tlg.ColumnCount;

                tlg.Controls.Add(myTable, column, row);
            }
        }

        private async void TableButton_Click(object sender, EventArgs e)
        {
            try
            {
                var table = ((Guna2Button)sender).Tag as Tables;

                if (formGuestsCount == null)
                {
                    formGuestsCount = new FrmGuestCount();
                }

                bool isTableDivide = await new CassaSettings().IsTablesDivisibleAsync();
                var tableStatus = table.table_status;

                if (isTableDivide || tableStatus == (int)EnumTablesStatus.Free)
                {
                    GoToPageCashe(table);
                }
                else if (tableStatus == (int)EnumTablesStatus.Busy)
                {
                    Dialog.Error("Этот столик уже занят. Пожалуйста, выберите другой.");
                }
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка обработки выбора стола: {ex.Message}");
            }
        }

        private void GoToPageCashe(Tables table)
        {
            formGuestsCount.Init(table);
            if (formGuestsCount.ShowDialog() == DialogResult.OK)
            {
                var hall = halls[tabControl.SelectedIndex];
                using (var window = new FrmCashe(null, hall, table))
                {
                    if (window.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
































//using System;
//using System.Linq;
//using System.Drawing;
//using Guna.UI2.WinForms;
//using System.Windows.Forms;
//using System.Collections.Generic;
//using MyFinCassa.UC;
//using MyFinCassa.Model;
//using MyFinCassa.Helper;

//namespace MyFinCassa.UI_Forms
//{
//    public partial class FrmOrderSelectTable : Form
//    {
//        private List<Hall> halls;
//        FrmGuestCount formGuestsCount;

//        public FrmOrderSelectTable()
//        {
//            InitializeComponent();
//            InitHalls();
//        }

//        private async void InitHalls()
//        {
//            halls = await new Hall().OnLoadHallsAsync();

//            TabPage tabPage;
//            foreach (var i in halls)
//            {
//                tabPage = new TabPage(i.hall_name);
//                tabControl.TabPages.Add(tabPage);
//            }
//            UpdateTable();
//        }

//        private async void UpdateTable()
//        {
//            var tabSelectedIndex = tabControl.SelectedIndex;
//            var index = Convert.ToInt32(halls[tabSelectedIndex].hall_id);

//            var tables = (await new Tables().OnLoadAsync()).Where(u => u.table_hall_id == index).ToList();
//            TabPage currentTab = tabControl.SelectedTab;

//            CreateTableLayoutGroup(tables, currentTab, tables.Count);
//        }

//        public async void CreateTableLayoutGroup(List<Tables> tables, Control parent, int userControlCount)
//        {
//            // Проверяем, что количество usercontrol больше нуля
//            if (userControlCount <= 0)
//            {
//                return;
//            }

//            #region [Вычет строк и столбцов]
//            if (!(Controls.Find(parent.Text, true).FirstOrDefault() is TableLayoutPanel tlg))
//            {
//                tlg = new TableLayoutPanel
//                {
//                    Name = parent.Text
//                };
//                int rowCount;
//                int columnCount;

//                if (userControlCount < 5)
//                {
//                    rowCount = 2;
//                    columnCount = userControlCount;
//                }
//                else if (userControlCount <= 6)
//                {
//                    rowCount = 2;
//                    columnCount = 3;
//                }
//                else if (userControlCount <= 8)
//                {
//                    rowCount = 2;
//                    columnCount = 4;
//                }
//                else if (userControlCount <= 10)
//                {
//                    rowCount = 2;
//                    columnCount = 5;
//                }
//                else if (userControlCount <= 12)
//                {
//                    rowCount = 3;
//                    columnCount = 4;
//                }
//                else if (userControlCount <= 15)
//                {
//                    rowCount = 3;
//                    columnCount = 5;
//                }
//                else if (userControlCount <= 20)
//                {
//                    rowCount = 4;
//                    columnCount = 5;
//                }
//                else if (userControlCount < 25)
//                {
//                    rowCount = 4;
//                    columnCount = 6;
//                }
//                else if (userControlCount <= 30)
//                {
//                    rowCount = 5;
//                    columnCount = 6;
//                }
//                else if (userControlCount <= 36)
//                {
//                    rowCount = 6;
//                    columnCount = 6;
//                }
//                else
//                {
//                    rowCount = (userControlCount - 1) / 6 + 1; // округляем вверх
//                    columnCount = Math.Min(userControlCount, 6); // не больше 5'и
//                }

//                tlg.RowCount = rowCount;
//                tlg.ColumnCount = columnCount;
//                // Задаем размеры строк и столбцов в процентах
//                for (int i = 0; i < rowCount; i++)
//                {
//                    tlg.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rowCount));
//                }
//                for (int i = 0; i < columnCount; i++)
//                {
//                    tlg.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount));
//                }
//                tlg.Dock = DockStyle.Fill;
//                parent.Controls.Add(tlg);
//            }
//            else
//            {
//                tlg.Controls.Clear();
//            }
//            #endregion

//            MyTable myTable;
//            var tablesStatus = await new TableStatus().OnLoadAsync();
//            for (int j = 0; j < tables.Count; j++)
//            {
//                var i = tables[j];
//                i.hall = halls.Where(u => u.hall_id == i.table_hall_id).FirstOrDefault();
//                i.tables_status = tablesStatus.Where(u => u.table_st_id == i.table_status).FirstOrDefault();
//                myTable = new MyTable();
//                myTable.btn.Text = $"Стол: #{i.table_name}\nМест: {i.table_place}";
//                switch (i.table_status)
//                {
//                    case (int)EnumTablesStatus.Free:
//                        myTable.btn.FillColor = Color.SeaGreen;
//                        break;
//                    case (int)EnumTablesStatus.Busy:
//                        myTable.btn.FillColor = Color.FromArgb(152, 48, 48);

//                        break;
//                    case (int)EnumTablesStatus.Booked:
//                        myTable.btn.FillColor = Color.FromArgb(36, 36, 36);
//                        break;
//                }
//                myTable.Dock = DockStyle.Fill;
//                myTable.btn.Tag = i;
//                myTable.btn.Click += TableButton_Click;
//                //  myTable.Button.Text = $"Название: {i.table_name}\nК-во мест: {i.table_place}\nСтатус: {i.tables_status.table_st_name}";

//                int row = j / tlg.ColumnCount; // целочисленное деление
//                int column = j % tlg.ColumnCount; // остаток от деления
//                tlg.Controls.Add(myTable, column, row);
//            }
//        }

//        private async void TableButton_Click(object sender, EventArgs e)
//        {
//            Tables myTable = ((Guna2Button)sender).Tag as Tables;

//            if (formGuestsCount == null)
//            {
//                formGuestsCount = new FrmGuestCount();
//            }

//            bool isTableDivide = await new CassaSettings().IsTablesDivisibleAsync();
//            var tableStatus = myTable.table_status;

//            if (isTableDivide || tableStatus == (int)EnumTablesStatus.Free)
//            {
//                GoToPageCashe(myTable);
//            }
//            else if (tableStatus == (int)EnumTablesStatus.Busy)
//            {
//                Dialog.Error("Этот столик уже занят. Пожалуйста, выберите другой.");
//            }
//        }

//        private void GoToPageCashe(Tables table)
//        {
//            formGuestsCount.Init(table);
//            if (formGuestsCount.ShowDialog() == DialogResult.OK)
//            {
//                var hall = halls[tabControl.SelectedIndex];
//                var window = new FrmCashe(null, hall, table);
//                if (window.ShowDialog() == DialogResult.OK)
//                {
//                    DialogResult = DialogResult.OK;
//                }
//            }
//        }

//        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            UpdateTable();
//        }

//        private void btnX_Click(object sender, System.EventArgs e)
//        {
//            Close();
//        }
//    }
//}

