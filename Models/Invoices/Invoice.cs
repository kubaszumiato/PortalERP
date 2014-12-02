using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalERP.Models.Invoices
{
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
        public IList<Element> items { get; set; }
    }
    public class InvoiceElement
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
    }
}