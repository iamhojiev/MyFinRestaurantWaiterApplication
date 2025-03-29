using MyFinCassa.Database;
using MyFinCassa.Model;
using System.Drawing;
using System.Drawing.Printing;
using System;
using System.Collections.Generic;

namespace MyFinCassa.Helper
{
    public static class PrinterService
    {
        public static bool PrintWaiterOrder(List<Product> products, Order order, string printerName)
        {
            try
            {
                var printer = new Printer(order, products);
                using (var recordDoc = new PrintDocument())
                {
                    recordDoc.DocumentName = "Чек";
                    recordDoc.PrintPage += new PrintPageEventHandler(printer.RenderWaiterReceipt);
                    recordDoc.PrintController = new StandardPrintController();
                    recordDoc.PrinterSettings.PrinterName = printerName;

                    if (!recordDoc.PrinterSettings.IsValid)
                    {
                        Dialog.Error("Принтер недоступен или настроен неверно.");
                        return false;
                    }

                    recordDoc.Print();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при печати чека: {ex.Message}");
                return false;
            }
        }

        public static void PrintRemovedProduct(Order order, Product product, string printerName)
        {
            var printer = new Printer(order, product);
            using (var recordDoc = new PrintDocument())
            {
                recordDoc.DocumentName = "Чек";
                recordDoc.PrintPage += new PrintPageEventHandler(printer.RenderReceiptRemove);
                recordDoc.PrintController = new StandardPrintController();
                recordDoc.PrinterSettings.PrinterName = printerName;

                if (!recordDoc.PrinterSettings.IsValid)
                {
                    Dialog.Error("Принтер недоступен.");
                    return;
                }

                recordDoc.Print();
            }
        }

        public static void PrintCancelOrder(Order order, List<Product> products, string printerName)
        {
            var printer = new Printer(order, products);
            using (var recordDoc = new PrintDocument())
            {
                recordDoc.DocumentName = "Чек";
                recordDoc.PrintPage += new PrintPageEventHandler(printer.RenderOrderCancelReceipt);
                recordDoc.PrintController = new StandardPrintController();
                recordDoc.PrinterSettings.PrinterName = printerName;

                if (!recordDoc.PrinterSettings.IsValid)
                {
                    Dialog.Error("Принтер недоступен.");
                    return;
                }

                recordDoc.Print();
            }
        }

        public static void PrintOrder(Order order, string printerName, EnumRenderType renderType, bool payed = false, double price = 0.0)
        {
            var printer = payed ? new Printer(order, true, price) : new Printer(order);

            try
            {
                using (var recordDoc = new PrintDocument())
                {
                    recordDoc.DocumentName = "Чек";
                    recordDoc.PrintPage += (s, e) =>
                    {
                        if (renderType == EnumRenderType.Restaurant)
                            printer.RenderOrderReceiptRestaurant(s, e);
                        else
                            printer.RenderOrderReceiptCafe(s, e);
                    };
                    recordDoc.PrintController = new StandardPrintController();
                    recordDoc.PrinterSettings.PrinterName = printerName;

                    if (!recordDoc.PrinterSettings.IsValid)
                    {
                        Dialog.Error("Принтер недоступен.");
                        return;
                    }

                    recordDoc.Print();
                }
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка печати: {ex.Message}");
            }
        }
    }
}
