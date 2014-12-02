using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using PortalERP.Models;

namespace PortalERP.Services
{
    public class OrdersService
    {
        private static List<Order> Orders { get; set; }

        static OrdersService()
        {
            Orders = InitializeOrders();
        }

        private static List<Order> InitializeOrders()
        {
            var customers = CustomersService.GetCustomers();
            var orders = new List<Order>();
            var i = 0;
            foreach (var customer in customers)
            {
                var order = new Order
                {
                    Customer = customer,
                    Address = new Address(),
                    Description = "description " + i++,
                    Guid = Guid.NewGuid().ToString(),
                    Id = new Random(i).Next(),
                    Numerator = "SO\\" + new Random(i).Next() +"\\2014",
                    ReferenceNumber = "reference" + new Random(i).Next(),
                    Registered = new DateTime(new Random(i).Next()),
                    Tags = new List<string>(),
                    Items = new List<Element>()
                };
                for (int j = 0; j < 3; j++)
                {
                    order.Tags.Add("#" + new Random(i).Next());
                }
                for (int x = 0; x < 4; x++)
                {
                    var item = new Element
                    {
                        code = "Article" + new Random(i).Next(),
                        id = new Random(i).Next(),
                        name = "Name" + new Random(i).Next(),
                        price = new Random(i).NextDouble(),
                        quantity = new Random(i).Next()
                    };
                    order.Items.Add(item);
                }
                orders.Add(order);
            }

            return orders;
        }

        public static Order GetOrder(int id)
        {
            return Orders.FirstOrDefault(o => o.Id == id);
        }

        public static List<Order> GetOrders()
        {
            return Orders;
        }
    }
}