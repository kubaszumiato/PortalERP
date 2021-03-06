﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.BuilderProperties;
using PortalERP.Models.Customers;

namespace PortalERP.Models
{
    //Orders
    public class Element
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
    }

    public class Document
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
        public IList<Element> Items { get; set; }
    }

    public class Order : Document
    {

    }

    public class Address
    {
        public Contact Contact { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public City City { get; set; }
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