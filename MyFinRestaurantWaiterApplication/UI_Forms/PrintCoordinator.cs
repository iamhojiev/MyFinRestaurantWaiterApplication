using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MyFinCassa.Model;
using MyFinCassa.Helper;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinCassa.UI_Forms
{
    public partial class PrintCoordinator : Form
    {

        public PrintCoordinator()
        {
            InitializeComponent();
            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                var ordersToPrint = await new ComplexDataService().GetOrdersForPrintAsync();
                foreach (var order in ordersToPrint)
                {
                    var groupedByKitchen = order.products
                        .GroupBy(product => product.kitchen)
                        .ToList();

                    // Поочередно обрабатываем каждую группу продуктов
                    foreach (var group in groupedByKitchen)
                    {
                        // group.Key – объект Kitchen, по которому сгруппированы продукты
                        // group.ToList() – список продуктов для данной кухни
                        PrinterHelper.PrintWaiterOrderReceipt(group.ToList(), order, group.Key);
                    }

                    // Обновляем статус печати для заказа после обработки всех групп
                    await new Order().OnUpdatePrintStatusAsync(order);
                }
            }
            catch (Exception ex)
            {
                Dialog.Error($"Ошибка при печати заказа: {ex.Message}");
            }
            finally
            {
                timer1.Start();
            }
        }

    }
}
//var orderToPrint = await new Order().SelectOrdersForPrintAsync();
//if (orderToPrint != null)
//{
//    foreach (var kitchen in kitchens)
//    {
//        var complexData = await new ComplexDataService()
//            .OnSelectByKitchenAsync(orderToPrint.order_main, orderToPrint.order_sub, kitchen.kitchen_id, true);

//        if (complexData.Products.Count > 0)
//        {
//            PrinterHelper.PrintWaiterOrderReceipt(complexData.Products, orderToPrint, kitchen);
//        }
//    }
//    await new Order().OnUpdatePrintStatusAsync(orderToPrint);
//}