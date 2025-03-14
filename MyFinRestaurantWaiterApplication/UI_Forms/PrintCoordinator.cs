using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections.Generic;
using MyFinCassa.Model;
using MyFinCassa.Helper;
using MyFinCassa.Database;

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
                var orderToPrint = await new Order().SelectOrdersForPrintAsync();
                if (orderToPrint != null)
                {
                    var kitchens = await new Kitchen().OnLoadAsync();
                    foreach (var kitchen in kitchens)
                    {
                        var complexData = await new DetailsProductComplex()
                            .OnSelectByKitchenAsync(orderToPrint.order_main, orderToPrint.order_sub, kitchen.kitchen_id, true);

                        if (complexData.Products.Count > 0)
                        {
                            OnPrintWaiterOrder(complexData.Products, orderToPrint, kitchen);
                        }
                    }
                    await new Order().OnUpdatePrintStatusAsync(orderToPrint);
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
