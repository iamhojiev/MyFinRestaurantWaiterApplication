using MyFinCassa.Database;
using MyFinCassa.Model;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections.Generic;
using System;

namespace MyFinCassa.Helper
{
    class Printer
    {
        private Order order = null;
        private Product product = null;
        private List<Product> myProducts = null;
        private bool status = false;
        private double price;

        private float y = 10;
        private readonly float x = 10;
        private readonly float width = DataSQL.OnMyConfig().printer_width;
        private readonly float height = 0F;

        private readonly Font drawFontArial10Regular = new Font("Arial", 9);
        private readonly Font drawFontArialBold = new Font("Arial", 9, FontStyle.Bold);
        private readonly SolidBrush drawBrush = new SolidBrush(Color.Black);

        // Set format of string.
        private readonly StringFormat drawFormatCenter = new StringFormat
        {
            Alignment = StringAlignment.Center
        };
        private readonly StringFormat drawFormatLeft = new StringFormat
        {
            Alignment = StringAlignment.Near
        };
        private readonly StringFormat drawFormatRight = new StringFormat
        {
            Alignment = StringAlignment.Far
        };

        //public Printer(Order order, bool status = false, double price = 0.0)
        //{
        //    this.order = order;
        //    this.status = status;
        //    this.price = price;
        //}
        //public Printer(List<Product> myProducts, Order order)
        //{
        //    this.order = order;
        //    this.myProducts = myProducts;
        //}
        //public Printer(Order order, Product product)
        //{
        //    this.order = order;
        //    this.product = product;
        //}

        public void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            //double orderFullPrice = 0.0;
            //double fullPercent = 0.0;

            //var orders = await new Order().SelectAllOrdersAndSubOrdersAsync(order.order_main);
            //foreach (var or in orders)
            //{
            //    orderFullPrice += or.order_price;
            //    fullPercent += or.order_price_waiter;
            //}

            //order.orderDetails = await new OrderDetails().OnSelectAllOrderDetailsAsync(order.order_main);

            //var allProduct = await new Product().OnLoadAsync();
            //foreach (var i in order.orderDetails)
            //    i.product = allProduct.FirstOrDefault(u => u.prod_id == i.details_prod);

            //order.tables = (await new Tables().OnLoadAsync()).FirstOrDefault(u => u.table_id == order.order_table);
            //var hall = (await new Hall().OnLoadAllAsync()).FirstOrDefault(u => u.hall_id == order.tables.table_hall_id);
            // var waiter = await new User().OnSelectUserAsync(order.order_user);

            //var cashier = await new User().OnSelectUserAsync(Settings.Default.user_id);
            //var cassa = await new Cassa().OnSelectCassaAsync(Settings.Default.mycassa_id);

            var cashier = "Mahmud";
            var cassa = "Kassa #1";

            string text = "Слово",
                date = order.order_date,
                date_close = order.order_close_date;

            text = DataSQL.OnMyConfig().name_rest;

            e.Graphics.DrawString($"Зал:", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString($"{order.GetHallName}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            e.Graphics.DrawString($"Стол:", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString($"{order.GetTableName}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            e.Graphics.DrawString($"Открыт:", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString($"{date}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            if (order.order_status == (int)EnumOrderStatus.Paid)
            {
                e.Graphics.DrawString($"Закрыт:", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                e.Graphics.DrawString($"{date_close}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += e.Graphics.MeasureString(text, drawFontArialBold).Height;
            }

            e.Graphics.DrawString($"Официант:", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString($"{order.GetUserName}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;

            e.Graphics.DrawString("Наименование", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString("\t\tКол-во", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            e.Graphics.DrawString("Сумма", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            var list = order.orderDetails;

            string name_eat = "";

            foreach (var i in list)
            {
                foreach (var q in list)
                {
                    if (i.details_prod == q.details_prod && i.details_id != q.details_id)
                    {
                        i.details_count += q.details_count;
                        q.details_count = 0;
                    }
                }
            }

            foreach (var i in list)
            {
                if (i.details_count > 0)
                {
                    name_eat = Text(i.product.prod_name);
                    e.Graphics.DrawString(name_eat, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    e.Graphics.DrawString($"\t\t{i.details_count}", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);

                    e.Graphics.DrawString(string.Format("{0:f2} ({1:f2})", i.product.prod_price * i.details_count, i.product.prod_price), drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);

                    y += e.Graphics.MeasureString(name_eat, drawFontArial10Regular).Height;
                }
            }
            e.Graphics.DrawString($"Касса: {cassa}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;
            e.Graphics.DrawString($"Кассир: {cashier}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;
            e.Graphics.DrawString($"Зал/Кабина:", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            if (order.tables.hall.hall_type != (int)EnumHallType.TimeBased)
                e.Graphics.DrawString($"{order.tables.hall.hall_price}", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            else
                CalculateTimeBasedPrice(e, order.tables.hall);

            y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;

            var percent = await new Payment().OnGetPercentAsync();
            e.Graphics.DrawString($"За обслуживание ({percent}%):", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString($"{order.order_price_waiter}", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;


            y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;
            e.Graphics.DrawString(order.order_status == (int)EnumOrderStatus.Paid ? "СУММА ЗАКАЗА:" : "К ОПЛАТЕ:", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString(string.Format("{0:f2}", order.order_price), drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;

            if (status)
            {
                e.Graphics.DrawString("ВНЕСЕНО:", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                e.Graphics.DrawString(string.Format("{0:f2}", price), drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;

                e.Graphics.DrawString("СДАЧА:", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                e.Graphics.DrawString(string.Format("{0:f2}", price - order.order_price), drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;
            }
            y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;
            text = DataSQL.OnMyConfig().bottom_check;
            e.Graphics.DrawString(text, drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;
        }

        private void CalculateTimeBasedPrice(PrintPageEventArgs e, Hall hall)
        {
            var now = DateTime.Now;
            if (DateTime.TryParse(order.order_date, out var orderDate))
            {
                TimeSpan difference = now - orderDate;
                var minutesElapsed = difference.TotalMinutes;
                var minuteBonus = hall.hall_bonus;

                if (minutesElapsed > minuteBonus)
                {
                    var hallPrice = Math.Round(((minutesElapsed - minuteBonus) / 60) * hall.hall_price, 2);
                    e.Graphics.DrawString($"{hallPrice:F2}({difference.Hours:D2}ч:{difference.Minutes:D2}м)", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                }
                else
                    e.Graphics.DrawString("0.0", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);

            }
        }

        public async void PrintReceiptPageWaiter(object sender, PrintPageEventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            // order.orderDetails = new OrderDetails().OnSelect(order.order_id);
            // var allProduct = new Product().OnLoad();
            //  foreach (var i in order.orderDetails)
            //     i.product = allProduct.Where(u => u.prod_id == i.details_prod).FirstOrDefault();
            var user = await new User().OnSelectUserAsync(order.order_user);

            string text = "Слово";
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////

            e.Graphics.DrawString($"Заказ №{order.OrderNum}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;
            e.Graphics.DrawString($"Официант:", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString($"{user.user_name}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            e.Graphics.DrawString("Наименование", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString("Кол-во", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            //var list = order.orderDetails;

            string name_eat;
            foreach (var i in myProducts)
            {
                if (i.prod_status != (int)EnumDetailsStatus.Ready)
                {
                    switch (i.prod_status)
                    {
                        case (int)EnumDetailsStatus.Return:
                            name_eat = "[Возврат]" + Text(i.prod_name);
                            break;
                        case (int)EnumDetailsStatus.Edit:
                            name_eat = "[Изм.]" + Text(i.prod_name);
                            break;
                        default:
                            name_eat = Text(i.prod_name);
                            break;
                    }

                    e.Graphics.DrawString(name_eat, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    e.Graphics.DrawString($"{i.prod_total}", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += e.Graphics.MeasureString(name_eat, drawFontArial10Regular).Height;
                }
            }
        }

        public void OrderCancel(object sender, PrintPageEventArgs e)
        {
            string text = "Слово";

            e.Graphics.DrawString($"Заказ отменен №{order.OrderNum}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            e.Graphics.DrawString("Наименование", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString("Кол-во", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            string name_eat;
            foreach (var i in myProducts)
            {
                name_eat = Text(i.prod_name);
                e.Graphics.DrawString(name_eat, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                e.Graphics.DrawString($"{i.prod_total}", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += e.Graphics.MeasureString(name_eat, drawFontArial10Regular).Height;
            }
        }

        public void PrintReceiptRemove(object sender, PrintPageEventArgs e)
        {
            var text = "Слово";

            e.Graphics.DrawString($"Заказ №{order.OrderNum}", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            e.Graphics.DrawString("Блюдо отменено", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;

            e.Graphics.DrawString(product.prod_name, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            e.Graphics.DrawString($"{product.prod_total}", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(product.prod_name, drawFontArial10Regular).Height;
        }

        public void PrintReceiptCancel(object sender, PrintPageEventArgs e)
        {
            var text = "Слово";

            e.Graphics.DrawString($"Заказ №{order.OrderNum} отменен!", drawFontArialBold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArialBold).Height;
        }

        private string Text(string str)
        {
            int MAX = 15,
                Length = str.Length,
                i = 0;

            string long_text = "";
            if (str.Length > MAX)
            {
                while (Length > 0)
                {
                    if (Length > MAX)
                    {
                        long_text = long_text + str.Substring(MAX * i, MAX);
                        long_text = long_text + "\n";

                        Length -= MAX;
                        i++;
                    }
                    else
                    {
                        long_text = long_text + str.Substring(MAX * i, Length);
                        Length -= Length;
                    }
                }
                return long_text;
            }
            return str;
        }
    }
}
