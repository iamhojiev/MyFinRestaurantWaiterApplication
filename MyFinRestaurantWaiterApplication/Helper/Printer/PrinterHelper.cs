using MyFinCassa.Database;
using MyFinCassa.Model;
using System.Collections.Generic;

namespace MyFinCassa.Helper
{

    public static class PrinterHelper
    {
        public static bool PrintWaiterOrderReceipt(List<Product> products, Order order, Kitchen kitchen)
        {
            if (string.IsNullOrEmpty(kitchen.kitchen_printer))
            {
                Dialog.Error("Принтер не настроен.");
                return false;
            }

            return PrinterService.PrintWaiterOrder(products, order, kitchen.kitchen_printer);
        }

        public static void PrintProductRemovalReceipt(Order order, Product product)
        {
            string printerName = DataSQL.OnMyConfig()?.printerWaiter;

            if (string.IsNullOrEmpty(printerName))
            {
                Dialog.Error("Принтер не настроен.");
                return;
            }

            PrinterService.PrintRemovedProduct(order, product, printerName);
        }

        public static void PrintOrderCancelReceipt(Order order, List<Product> products)
        {
            string printerName = DataSQL.OnMyConfig()?.printer;

            if (string.IsNullOrEmpty(printerName))
            {
                Dialog.Error("Принтер не настроен.");
                return;
            }

            PrinterService.PrintCancelOrder(order, products, printerName);
        }

        public static void PrintOrderReceipt(Order order, bool payed = false, double price = 0.0)
        {
            string printerName = DataSQL.OnMyConfig()?.printer;

            if (string.IsNullOrEmpty(printerName))
            {
                Dialog.Error("Принтер не настроен.");
                return;
            }

            PrinterService.PrintOrder(order, printerName, payed, price);
        }
    }

    //private static bool OnPrintWaiterOrder(List<Product> products, Order order, Kitchen kitchen)
    //{
    //    try
    //    {
    //        var printer = new Printer(products, order);

    //        using (var recordDoc = new PrintDocument())
    //        {
    //            recordDoc.DocumentName = "Чек";
    //            recordDoc.PrintPage += new PrintPageEventHandler(printer.PrintReceiptPageWaiter);
    //            recordDoc.PrintController = new StandardPrintController();
    //            recordDoc.PrinterSettings.PrinterName = kitchen.kitchen_printer;

    //            if (recordDoc.PrinterSettings.IsValid)
    //            {
    //                recordDoc.Print();
    //                return true;
    //            }
    //            else
    //            {
    //                Dialog.Error("Принтер недоступен или настроен неверно.");
    //                return false;
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Dialog.Error($"Ошибка при печати чека: {ex.Message}");
    //        return false;
    //    }
    //}

    //private void PrintRemoveProduct(Order order, Product product)
    //{
    //    string printerName = DataSQL.OnMyConfig()?.printerWaiter;

    //    if (string.IsNullOrEmpty(printerName))
    //    {
    //        Dialog.Error("Принтер не настроен.");
    //        return;
    //    }

    //    Printer printer;

    //    printer = new Printer(order, product);

    //    var recordDoc = new PrintDocument
    //    {
    //        DocumentName = "Чек"
    //    };
    //    recordDoc.PrintPage += new PrintPageEventHandler(printer.PrintReceiptRemove);
    //    recordDoc.PrintController = new StandardPrintController();

    //    recordDoc.PrinterSettings.PrinterName = DataSQL.OnMyConfig().printerWaiter;

    //    if (recordDoc.PrinterSettings.IsValid)
    //    {
    //        recordDoc.Print();
    //        recordDoc.Dispose();
    //    }
    //}

    //public void StartPrint(Order order, bool payed = false, double price = 0.0)
    //{
    //    string printerName = DataSQL.OnMyConfig()?.printer;

    //    if (string.IsNullOrEmpty(printerName))
    //    {
    //        Dialog.Error("Принтер не настроен.");
    //        return;
    //    }

    //    Printer printer;

    //    if (payed)
    //        printer = new Printer(order, true, price);
    //    else
    //        printer = new Printer(order);

    //    try
    //    {
    //        using (var recordDoc = new PrintDocument())
    //        {
    //            recordDoc.DocumentName = "Чек";
    //            recordDoc.PrinterSettings.PrinterName = printerName;

    //            if (!recordDoc.PrinterSettings.IsValid)
    //            {
    //                Dialog.Error("Принтер недоступен.");
    //                return;
    //            }

    //            recordDoc.PrintPage += (s, e) => new Printer(myOrder).PrintReceiptPage(this, e);
    //            recordDoc.PrintController = new StandardPrintController();
    //            recordDoc.Print();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Dialog.Error($"Ошибка печати: {ex.Message}");
    //    }
    //}
}
