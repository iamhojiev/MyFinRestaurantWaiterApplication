using MyFinCassa.Model;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace MyFinCassa.Helper
{
    public static class OrdersParser
    {
        public static List<Order> DeserializePrintOrders(string json)
        {
            // Разбираем JSON как массив объектов
            JArray jsonArray = JArray.Parse(json);

            // Словарь для группировки заказов по order_id (чтобы избежать дублирования заказа при повторении записей для деталей)
            Dictionary<int, Order> ordersDictionary = new Dictionary<int, Order>();

            foreach (var item in jsonArray)
            {
                // Извлекаем идентификатор заказа
                int orderId = item.Value<int>("order_id");

                // Если заказ ещё не создан – создаём новый экземпляр Order
                if (!ordersDictionary.TryGetValue(orderId, out Order order))
                {
                    order = new Order
                    {
                        order_id = orderId,
                        order_sub = item.Value<int>("order_sub"),
                        order_main = item.Value<int>("order_main"),
                        order_table = item.Value<int>("order_table"),
                        print_status = item.Value<int>("print_status"),
                        order_date = item.Value<string>("order_date"),
                        order_close_date = item.Value<string>("order_close_date"),
                        order_price = item.Value<double>("order_price"),
                        order_discount = item.Value<double>("order_discount"),
                        order_user = item.Value<int>("order_user"),
                        order_guest = item.Value<int>("order_guest"),
                        order_shift = item.Value<int>("order_shift"),
                        order_payment = item.Value<int>("order_payment"),
                        order_status = item.Value<int>("order_status"),
                        order_delivery = item.Value<int>("order_delivery"),
                        order_comment = item.Value<string>("order_comment"),
                        order_status_cook = item.Value<int>("order_status_cook"),
                        order_price_waiter = item.Value<double>("order_price_waiter"),
                        order_price_hall = item.Value<double>("order_price_hall"),
                        user = new User
                        {
                            user_id = item.Value<int>("user_id"),
                            user_name = item.Value<string>("user_name"),
                            user_password = item.Value<string>("user_password"),
                            user_role = item.Value<int>("user_role"),
                            user_kitchen = item.Value<int>("user_kitchen"),
                            user_salary = item.Value<double>("user_salary"),
                            user_salary_type = item.Value<int>("user_salary_type"),
                            user_last_payment = item.Value<string>("user_last_payment"),
                            user_earnings = item.Value<double>("user_earnings"),
                            user_paid = item.Value<double>("user_paid"),
                            user_bonus = item.Value<double>("user_bonus"),
                            user_fine = item.Value<double>("user_fine")
                        },
                        products = new List<Product>()
                    };

                    ordersDictionary.Add(orderId, order);
                }

                // Создаём объект детали заказа
                Product product = new Product
                {
                    prod_id = item.Value<int>("prod_id"),
                    prod_name = item.Value<string>("prod_name"),
                    prod_price = item.Value<double>("prod_price"),
                    prod_cooking_minutes = item.Value<int>("prod_cooking_minutes"),
                    prod_total = item.Value<double>("details_count"),
                    prod_value = item.Value<int>("prod_value"),
                    prod_category = item.Value<int>("prod_category"),
                    prod_type = item.Value<int>("prod_type"),
                    prod_sub_order = item.Value<int>("prod_sub_order"),
                    prod_start_price = item.Value<double>("prod_start_price"),
                    prod_kitchen = item.Value<int>("prod_kitchen"),
                    prod_status = item.Value<int>("prod_status"),
                    prod_comment = item.Value<string>("prod_comment"),
                    kitchen = new Kitchen
                    {
                        kitchen_id = item.Value<int>("kitchen_id"),
                        kitchen_name = item.Value<string>("kitchen_name"),
                        kitchen_printer = item.Value<string>("kitchen_printer")
                    },
                    type = new Type
                    {
                        type_id = item.Value<int>("type_id"),
                        type_name = item.Value<string>("type_name")
                    }
                };

                // Добавляем деталь заказа в список деталей для данного заказа
                ordersDictionary[orderId].products.Add(product);
            }

            // Преобразуем значения словаря в список заказов
            return ordersDictionary.Values.ToList();
        }

        //    public static List<Order> DeserializePrintOrders(string json)
        //    {
        //        // Разбираем JSON как массив объектов
        //        JArray jsonArray = JArray.Parse(json);

        //        // Словарь для группировки заказов по order_id (чтобы избежать дублирования заказа при повторении записей для деталей)
        //        Dictionary<int, Order> ordersDictionary = new Dictionary<int, Order>();

        //        foreach (var item in jsonArray)
        //        {
        //            // Извлекаем идентификатор заказа
        //            int orderId = item.Value<int>("order_id");

        //            // Если заказ ещё не создан – создаём новый экземпляр Order
        //            if (!ordersDictionary.TryGetValue(orderId, out Order order))
        //            {
        //                order = new Order
        //                {
        //                    order_id = orderId,
        //                    order_sub = item.Value<int>("order_sub"),
        //                    order_main = item.Value<int>("order_main"),
        //                    order_table = item.Value<int>("order_table"),
        //                    print_status = item.Value<int>("print_status"),
        //                    order_date = item.Value<string>("order_date"),
        //                    order_close_date = item.Value<string>("order_close_date"),
        //                    order_price = item.Value<double>("order_price"),
        //                    order_discount = item.Value<double>("order_discount"),
        //                    order_user = item.Value<int>("order_user"),
        //                    order_guest = item.Value<int>("order_guest"),
        //                    order_shift = item.Value<int>("order_shift"),
        //                    order_payment = item.Value<int>("order_payment"),
        //                    order_status = item.Value<int>("order_status"),
        //                    order_delivery = item.Value<int>("order_delivery"),
        //                    order_comment = item.Value<string>("order_comment"),
        //                    order_status_cook = item.Value<int>("order_status_cook"),
        //                    order_price_waiter = item.Value<double>("order_price_waiter"),
        //                    order_price_hall = item.Value<double>("order_price_hall"),
        //                    user = new User
        //                    {
        //                        user_id = item.Value<int>("user_id"),
        //                        user_name = item.Value<string>("user_name"),
        //                        user_password = item.Value<string>("user_password"),
        //                        user_role = item.Value<int>("user_role"),
        //                        user_kitchen = item.Value<int>("user_kitchen"),
        //                        user_salary = item.Value<double>("user_salary"),
        //                        user_salary_type = item.Value<int>("user_salary_type"),
        //                        user_last_payment = item.Value<string>("user_last_payment"),
        //                        user_earnings = item.Value<double>("user_earnings"),
        //                        user_paid = item.Value<double>("user_paid"),
        //                        user_bonus = item.Value<double>("user_bonus"),
        //                        user_fine = item.Value<double>("user_fine")
        //                    },
        //                    orderDetails = new List<OrderDetails>()
        //                };

        //                ordersDictionary.Add(orderId, order);
        //            }

        //            // Создаём объект детали заказа
        //            OrderDetails detail = new OrderDetails
        //            {
        //                details_id = item.Value<int>("details_id"),
        //                details_prod = item.Value<int>("details_prod"),
        //                details_count = item.Value<double>("details_count"),
        //                details_order = item.Value<int>("details_order"),
        //                details_sub_order = item.Value<int>("details_sub_order"),
        //                details_status = item.Value<int>("details_status"),
        //                details_comment = item.Value<string>("details_comment"),
        //                product = new Product
        //                {
        //                    prod_id = item.Value<int>("prod_id"),
        //                    prod_name = item.Value<string>("prod_name"),
        //                    prod_price = item.Value<double>("prod_price"),
        //                    prod_cooking_minutes = item.Value<int>("prod_cooking_minutes"),
        //                    prod_total = item.Value<double>("details_count"),
        //                    prod_value = item.Value<int>("prod_value"),
        //                    prod_category = item.Value<int>("prod_category"),
        //                    prod_type = item.Value<int>("prod_type"),
        //                    prod_sub_order = item.Value<int>("prod_sub_order"),
        //                    prod_start_price = item.Value<double>("prod_start_price"),
        //                    prod_kitchen = item.Value<int>("prod_kitchen"),
        //                    prod_status = item.Value<int>("prod_status"),
        //                    prod_comment = item.Value<string>("prod_comment"),
        //                    kitchen = new Kitchen
        //                    {
        //                        kitchen_id = item.Value<int>("kitchen_id"),
        //                        kitchen_name = item.Value<string>("kitchen_name"),
        //                        kitchen_printer = item.Value<string>("kitchen_printer")
        //                    },
        //                    type = new Type
        //                    {
        //                        type_id = item.Value<int>("type_id"),
        //                        type_name = item.Value<string>("type_name")
        //                    }
        //                }
        //            };

        //            // Добавляем деталь заказа в список деталей для данного заказа
        //            ordersDictionary[orderId].orderDetails.Add(detail);
        //        }

        //        // Преобразуем значения словаря в список заказов
        //        return ordersDictionary.Values.ToList();
        //    }
    }
}
