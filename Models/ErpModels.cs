using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.BuilderProperties;

namespace PortalERP.Models
{
    public class ErpModels
    {
        public class Customer
        {
            public string Id { get; set; }
            public int Index { get; set; }
            public bool IsActive { get; set; }
            public int Age { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
        }

        //Orders
        public class Item
        {
            public int id { get; set; }
            public string code { get; set; }
            public string name { get; set; }
            public double price { get; set; }
            public int quantity { get; set; }
        }

        public class Order
        {
            public int Id { get; set; }
            public string Guid { get; set; }
            public string Numerator { get; set; }
            public string ReferenceNumber { get; set; }
            public Customer Customer { get; set; }
            public Address Address { get; set; }
            public string Description { get; set; }
            public DateTime Registered { get; set; }
            public IList<string> Tags { get; set; }
            public IList<Item> Items { get; set; }
        }
    }



    public class Item
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
    }

    public class Invoice
    {
        public string _id { get; set; }
        public int index { get; set; }
        public string guid { get; set; }
        public bool isActive { get; set; }
        public string value { get; set; }
        public string numerator { get; set; }
        public string referenceNumber { get; set; }
        public string customer { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public string registered { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public IList<string> tags { get; set; }
        public IList<Item> items { get; set; }
    }



        public class Address
        {
            public Contact Contact { get; set; }    
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public City City { get; set; }
        }
    }

    public class City
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Contact
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}