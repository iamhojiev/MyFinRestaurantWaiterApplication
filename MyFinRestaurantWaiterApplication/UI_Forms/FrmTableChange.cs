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
    public partial class FrmTableChange : Form
    {
        private List<Hall> halls;
        public Tables SelectedTable { get; private set; }

        public FrmTableChange()
        {
            InitializeComponent();
            InitHalls();
        }

        private async void InitHalls()
        {
            try
            {
                var hallList = await new Hall().OnLoadHallsAsync();
                halls = hallList.Where(h => h.hall_type != (int)EnumHallType.TimeBased).ToList();

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
                var tableList = await new Tables().OnLoadAsync();
                var tables = tableList.Where(t => t.table_hall_id == hallId).ToList();
                CreateTableLayoutGroup(tables, tabControl.SelectedTab);
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка обновления столиков: {ex.Message}");
            }
        }

        public async void CreateTableLayoutGroup(List<Tables> tables, Control parent)
        {
            if (tables.Count <= 0) return;

            var tableStatusList = await new TableStatus().OnLoadAsync();

            var tlg = parent.Controls.OfType<TableLayoutPanel>().FirstOrDefault() ?? new TableLayoutPanel
            {
                Name = parent.Text,
                Dock = DockStyle.Fill
            };

            tlg.RowCount = Math.Max(1, (tables.Count - 1) / 6 + 1);
            tlg.ColumnCount = Math.Min(tables.Count, 6);

            tlg.RowStyles.Clear();
            tlg.ColumnStyles.Clear();

            for (int i = 0; i < tlg.RowCount; i++)
            {
                tlg.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / tlg.RowCount));
            }

            for (int i = 0; i < tlg.ColumnCount; i++)
            {
                tlg.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / tlg.ColumnCount));
            }

            parent.Controls.Add(tlg);
            tlg.Controls.Clear();

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

        private void TableButton_Click(object sender, EventArgs e)
        {
            if (((Guna2Button)sender).Tag is Tables table)
            {
                SelectedTable = table;
                DialogResult = DialogResult.OK;
            }
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
