using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyFinCassa.Model;
using MyFinCassa.UC;


namespace MyFinCassa.UI_Forms
{
    public partial class FrmOrderSelect : Form
    {
        public Order selectedOrder;
        private string currency;

        public FrmOrderSelect(List<Order> orders)
        {
            InitializeComponent();
            CreateTableLayoutGroup(orders, this, orders.Count);
        }

        public async void CreateTableLayoutGroup(List<Order> orders, Control parent, int ordersCount)
        {
            currency = await new Currency().OnGetCurrencyValueAsync();
            // Проверяем, что количество usercontrol больше нуля
            if (ordersCount <= 0)
            {
                return;
            }
            int maxCol = 3;
            if (ordersCount > 6)
                maxCol = 4;

            ResetTableLayout();

            #region [Вычет строк и столбцов]
            int rowCount = 0;
            int columnCount = 0;
            if (ordersCount < 5)
            {
                rowCount = 2;
                columnCount = ordersCount;
            }
            else if (ordersCount <= 6)
            {
                rowCount = 2;
                columnCount = 3;
            }
            else if (ordersCount <= 8)
            {
                rowCount = 2;
                columnCount = 4;
            }
            else if (ordersCount <= 10)
            {
                rowCount = 2;
                columnCount = 5;
            }
            else
            {
                rowCount = (ordersCount - 1) / maxCol + 1;
                columnCount = Math.Min(ordersCount, maxCol);
            }
            #endregion

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
            DateTime dateTime;
            for (int j = 0; j < ordersCount; j++)
            {
                var i = orders[j];

                myBtn = new MyButton(Helper.EnumMyButtonType.MediumGreen);
                myBtn.Dock = DockStyle.Fill;
                myBtn.Button.Tag = i;
                myBtn.Button.Click += OrderButton_Click;
                dateTime = DateTime.Parse(i.order_date);
                myBtn.Button.Text = $"№{i.order_main}\nОткрыто: {dateTime:HH:mm:ss}\nГостей: {i.order_guest}\nСумма: {i.order_price} {currency}.";

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

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (((Guna2Button)sender).Tag is Order aaa)
            {
                selectedOrder = aaa;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
