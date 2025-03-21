using MyFinCassa.Database;
using MyFinCassa.Model;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MyFinCassa.Helper
{

    public class Printer
    {
        private readonly Order order;
        private readonly List<Product> products;
        private readonly Product product;
        private readonly bool isPaid;
        private readonly double paidAmount;
        private float y = 10;
        private readonly float x = 10;
        private readonly float width = DataSQL.OnMyConfig().printer_width;
        private readonly float height = 0;
        private readonly Font drawFontArial9 = new Font("Consolas", 8);
        private readonly Font drawFontArialBold9 = new Font("Consolas", 8, FontStyle.Bold);
        private readonly Font drawFontFooter = new Font("Consolas", 10, FontStyle.Regular);
        private readonly Font drawFontRestaurantName = new Font("Comic Sans MS", 20);
        private readonly SolidBrush drawBrush = new SolidBrush(Color.Black);
        private readonly SolidBrush lineBrush = new SolidBrush(Color.Gray);

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

        public Printer(Order order, bool isPaid = false, double paidAmount = 0.0)
        {
            this.order = order;
            this.isPaid = isPaid;
            this.paidAmount = paidAmount;
        }

        public Printer(Order order, List<Product> products)
        {
            this.order = order;
            this.products = products;
        }

        public Printer(Order order, Product product)
        {
            this.order = order;
            this.product = product;
        }

        public void RenderOrderReceiptCafe(object sender, PrintPageEventArgs e)
        {
            float currentY = y;
            string restaurantName = DataSQL.OnMyConfig().name_rest;

            // Заголовок
            e.Graphics.DrawString(restaurantName, drawFontRestaurantName, drawBrush, new RectangleF(x, currentY, width, height), drawFormatCenter);
            currentY += 50;

            // Данные заказа
            PrintKeyValue(e, "Открыт:", order.order_date, ref currentY, drawFontArialBold9);

            if (order.order_status == (int)EnumOrderStatus.Paid)
            {
                PrintKeyValue(e, "Закрыт:", order.order_close_date, ref currentY, drawFontArialBold9);
            }

            currentY += 10;

            // Заголовок товаров
            PrintRow(e, "Наименование", "Кол-во", "Цена", ref currentY, drawFontArialBold9);

            // Объединяем позиции с одинаковыми товарами
            var groupedItems = order.orderDetails
                .GroupBy(d => d.details_prod)
                .Select(g => new
                {
                    Product = g.First().product,
                    TotalCount = g.Sum(d => d.details_count)
                });

            foreach (var item in groupedItems)
            {
                if (item.TotalCount > 0)
                {
                    string formattedName = FormatText(item.Product.prod_name);
                    string totalCost = $"{item.Product.prod_price * item.TotalCount:F2} ({item.Product.prod_price:F2})";

                    PrintRow(e, formattedName, item.TotalCount.ToString(), totalCost, ref currentY, drawFontArial9);
                }
            }
            PrintSeparatorLine(e, ref currentY, drawFontArialBold9);

            // Расчёт итоговых значений
            double totalQuantity = groupedItems.Sum(g => g.TotalCount);
            double totalSum = groupedItems.Sum(g => g.Product.prod_price * g.TotalCount);
            PrintRow(e, "Всего", totalQuantity.ToString(), totalSum.ToString("F2"), ref currentY, drawFontArialBold9);

            currentY += 20;

            // Информация по Delivery
            if (order.order_delivery == (int)EnumOrderType.Delivery)
            {
                PrintKeyValue(e, "Тип доставки:", order.tables.table_name, ref currentY, drawFontArialBold9);
                PrintKeyValue(e, "Цена доставки:", order.tables.hall.hall_price.ToString(), ref currentY, drawFontArialBold9);
            }

            // Итоговая сумма
            string totalText = isPaid ? "СУММА ЗАКАЗА:" : "К ОПЛАТЕ:";
            PrintKeyValue(e, totalText, $"{order.order_price:F2}", ref currentY, drawFontArialBold9);

            if (isPaid)
            {
                PrintKeyValue(e, "ВНЕСЕНО:", $"{paidAmount:F2}", ref currentY, drawFontArialBold9);
                PrintKeyValue(e, "СДАЧА:", $"{paidAmount - order.order_price:F2}", ref currentY, drawFontArialBold9);
            }

            currentY += 10;

            // Нижняя часть чека
            string bottomText = DataSQL.OnMyConfig().bottom_check;
            e.Graphics.DrawString(bottomText, drawFontFooter, drawBrush, new RectangleF(x, currentY, width, height), drawFormatCenter);
        }

        public void RenderOrderReceiptRestaurant(object sender, PrintPageEventArgs e)
        {
            float currentY = y;
            string restaurantName = DataSQL.OnMyConfig().name_rest;

            // Заголовок
            e.Graphics.DrawString(restaurantName, drawFontArialBold9, drawBrush, new RectangleF(x, currentY, width, height), drawFormatCenter);
            currentY += 30;

            // Данные заказа
            PrintKeyValue(e, "Зал:", order.GetHallName, ref currentY, drawFontArialBold9);
            PrintKeyValue(e, "Стол:", order.GetTableName, ref currentY, drawFontArialBold9);
            PrintKeyValue(e, "Открыт:", order.order_date, ref currentY, drawFontArialBold9);

            if (order.order_status == (int)EnumOrderStatus.Paid)
            {
                PrintKeyValue(e, "Закрыт:", order.order_close_date, ref currentY, drawFontArialBold9);
            }

            PrintKeyValue(e, "Официант:", order.GetUserName, ref currentY, drawFontArialBold9);
            currentY += 10;

            // Заголовок товаров
            PrintRow(e, "Наименование", "Кол-во", "Цена", ref currentY, drawFontArialBold9);

            // Объединяем позиции с одинаковыми товарами
            var groupedItems = order.orderDetails
                .GroupBy(d => d.details_prod)
                .Select(g => new
                {
                    Product = g.First().product,
                    TotalCount = g.Sum(d => d.details_count)
                });

            foreach (var item in groupedItems)
            {
                if (item.TotalCount > 0)
                {
                    string formattedName = FormatText(item.Product.prod_name);
                    string totalCost = $"{item.Product.prod_price * item.TotalCount:F2} ({item.Product.prod_price:F2})";

                    PrintRow(e, formattedName, item.TotalCount.ToString(), totalCost, ref currentY, drawFontArial9);
                }
            }

            currentY += 20;

            // Информация по залу/кабине
            string hallCost = "";
            if (order.tables.hall.hall_type == (int)EnumHallType.TimeBased)
            {
                if (DateTime.TryParse(order.order_date, out var orderDate))
                {
                    var (hallPrice, formattedTime) = HallPriceCalculator.CalculatePrice(order.tables.hall, orderDate);
                    hallCost = hallPrice > 0 ? $"{hallPrice:F2} ({formattedTime})" : "0.0";
                }
            }
            else
            {
                hallCost = $"{order.tables.hall.hall_price}";
            }
            PrintKeyValue(e, "Зал/Кабина:", hallCost, ref currentY, drawFontArialBold9);

            // Обслуживание
            var waiterePercent = Convert.ToInt32(order.order_price_waiter * 100 / (order.order_price + order.order_discount));
            PrintKeyValue(e, $"Обслуживание ({waiterePercent}%):", order.order_price_waiter.ToString(), ref currentY, drawFontArialBold9);
            currentY += 10;

            // Итоговая сумма
            string totalText = isPaid ? "СУММА ЗАКАЗА:" : "К ОПЛАТЕ:";
            PrintKeyValue(e, totalText, $"{order.order_price:F2}", ref currentY, drawFontArialBold9);

            if (isPaid)
            {
                PrintKeyValue(e, "ВНЕСЕНО:", $"{paidAmount:F2}", ref currentY, drawFontArialBold9);
                PrintKeyValue(e, "СДАЧА:", $"{paidAmount - order.order_price:F2}", ref currentY, drawFontArialBold9);
            }

            currentY += 10;

            // Нижняя часть чека
            string bottomText = DataSQL.OnMyConfig().bottom_check;
            e.Graphics.DrawString(bottomText, drawFontArialBold9, drawBrush, new RectangleF(x, currentY, width, height), drawFormatCenter);
        }

        public void RenderOrderCancelReceipt(object sender, PrintPageEventArgs e)
        {
            float currentY = y;
            e.Graphics.DrawString($"Заказ №{order.OrderNum} отменен", drawFontArialBold9, drawBrush, new RectangleF(x, currentY, width, height), drawFormatCenter);

            currentY += 30;
            PrintKeyValue(e, "Наименование", "Количество", ref currentY, drawFontArialBold9);

            foreach (var i in products)
            {
                PrintKeyValue(e, i.prod_name, i.prod_total.ToString(), ref currentY, drawFontArial9);
            }
        }

        public void RenderReceiptRemove(object sender, PrintPageEventArgs e)
        {
            float currentY = y;
            e.Graphics.DrawString($"Заказ №{order.OrderNum}", drawFontArialBold9, drawBrush, new RectangleF(x, currentY, width, height), drawFormatCenter);

            currentY += 30;
            e.Graphics.DrawString("Блюдо отменено", drawFontArialBold9, drawBrush, new RectangleF(x, currentY, width, height), drawFormatLeft);

            currentY += 20;
            PrintKeyValue(e, product.prod_name, product.prod_total.ToString(), ref currentY, drawFontArial9);
        }

        public void RenderWaiterReceipt(object sender, PrintPageEventArgs e)
        {
            float currentY = y;
            e.Graphics.DrawString($"Заказ №{order.OrderNum}", drawFontArialBold9, drawBrush, new RectangleF(x, currentY, width, height), drawFormatCenter);

            currentY += 20;
            PrintKeyValue(e, "Официант:", order.user.user_name, ref currentY, drawFontArial9);
            PrintKeyValue(e, "Наименование", "Количество", ref currentY, drawFontArialBold9);

            string prodName;
            foreach (var product in products)
            {
                prodName = GenerateProductName(product);
                PrintKeyValue(e, prodName, $"{product.prod_total:F2}", ref currentY, drawFontArial9, 0.65f);
            }
        }

        private string GenerateProductName(Product product)
        {
            string name = product.prod_name;

            if (product.prod_status != (int)EnumDetailsStatus.Ready)
            {
                switch (product.prod_status)
                {
                    case (int)EnumDetailsStatus.Return:
                        name = $"[Возврат] {name}";
                        break;
                    case (int)EnumDetailsStatus.Edit:
                        name = $"[Изм.] {name}";
                        break;
                    default:
                        //name = name;
                        break;
                }
            }

            return name;
        }

        #region [Вспомогательные методы для печати строк]

        // Метод для печати строки с заголовком и значением
        private void PrintKeyValue(PrintPageEventArgs e, string key, string value, ref float yPos, Font font, float keyPercentage = 0.5f)
        {
            // Вычисляем ширину для ключа и значения
            float keyWidth = width * keyPercentage;
            float valueWidth = width - keyWidth;

            // Отрисовка ключа по левому краю в выделенной области
            e.Graphics.DrawString(key, font, drawBrush,
                new RectangleF(x, yPos, keyWidth, height), drawFormatLeft);

            // Отрисовка значения по правому краю в оставшейся области
            e.Graphics.DrawString(value, font, drawBrush,
                new RectangleF(x + keyWidth, yPos, valueWidth, height), drawFormatRight);

            // Изменяем yPos на высоту отрисованного ключа + небольшой отступ.
            yPos += e.Graphics.MeasureString(key, font).Height + 5;
        }


        // Метод для печати строки с тремя колонками
        private void PrintRow(PrintPageEventArgs e, string col1, string col2, string col3, ref float yPos, Font font)
        {
            // Рисуем название товара (col1) и измеряем его высоту
            RectangleF col1Rect = new RectangleF(x, yPos, width / 2, 0);
            SizeF col1Size = e.Graphics.MeasureString(col1, font, col1Rect.Size, drawFormatLeft);
            e.Graphics.DrawString(col1, font, drawBrush, col1Rect, drawFormatLeft);

            // Вычисляем вертикальный центр для col2 и col3
            float centerY = yPos + (col1Size.Height / 2) - (font.Height / 2);

            // Рисуем кол-во (col2) по центру высоты названия
            e.Graphics.DrawString(col2, font, drawBrush, new RectangleF(x + width / 3, centerY, width / 3, font.Height), drawFormatCenter);

            // Рисуем цену (col3) по центру высоты названия
            e.Graphics.DrawString(col3, font, drawBrush, new RectangleF(x + 2 * (width / 3), centerY, width / 3, font.Height), drawFormatRight);

            // Обновляем позицию Y для следующей строки
            yPos += col1Size.Height + 5;
        }

        // Метод для форматирования длинных названий
        private string FormatText(string str)
        {
            int maxLength = 15;
            if (str.Length <= maxLength) return str;

            List<string> parts = new List<string>();
            for (int i = 0; i < str.Length; i += maxLength)
            {
                parts.Add(str.Substring(i, Math.Min(maxLength, str.Length - i)));
            }
            return string.Join("\n", parts);
        }

        // Вспомогательный метод для печати разделительной строки
        private void PrintSeparatorLine(PrintPageEventArgs e, ref float yPos, Font font)
        {
            int dashCount = 50;

            // Собираем строку, где каждый элемент — это '-', а в качестве разделителя используем пробел.
            string dashLine = string.Join(" ", Enumerable.Repeat("—", dashCount));

            e.Graphics.DrawString(dashLine, font, lineBrush, new RectangleF(x, yPos, width, font.Height), drawFormatCenter);
            yPos += font.Height + 5;
        }


        #endregion
    }
}
