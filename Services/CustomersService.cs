using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using PortalERP.Controllers;
using PortalERP.Models.Customers;

namespace PortalERP.Services
{
    public class CustomersService
    {
        private static List<Customer> Customers { get; set; }

        static CustomersService()
        {
            Customers = InitializeCustomers();
        }

        private static List<Customer> InitializeCustomers()
        {
            var customers = new List<Customer>();

            var customer = new Customer();
            customer.Id = "customer1";
            customer.Email = "customer1@gmail.com";
            customer.Age = 26;
            customer.IsActive = true;
            customer.Name = "Customer 1";
            customer.Phone = "56456456";
            customer.Address = "Address of Customer 1, Lille";
            customers.Add(customer);

            customer = new Customer();
            customer.Id = "customer2";
            customer.Email = "customer2@yahoo.com";
            customer.Age = 54;
            customer.IsActive = true;
            customer.Name = "Customer 2";
            customer.Phone = "3453945345";
            customer.Address = "Address of Customer 2, Kraków";
            customers.Add(customer);

            customer = new Customer();
            customer.Id = "customer3";
            customer.Email = "customer3@yahoo.com";
            customer.Age = 35;
            customer.IsActive = false;
            customer.Name = "Customer 3";
            customer.Phone = "345345345";
            customer.Address = "Address of Customer 3, Wroclaw";
            customers.Add(customer);

            customer = new Customer();
            customer.Id = "customer4";
            customer.Email = "customer4@voila.com";
            customer.Age = 26;
            customer.IsActive = true;
            customer.Name = "Customer 4";
            customer.Phone = "33429687676";
            customer.Address = "Address of Customer 4, Paris";
            customers.Add(customer);

            return customers;
        }

        public static Customer GetCustomer(string id)
        {
            return Customers.FirstOrDefault(c => c.Id == id);
        }

        public static List<Customer> GetCustomers()
        {
            return Customers;
        }
    }
}