using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalERP.Models.Invoices
{
    public class Invoice
    {
        public string Id { get; set; }
        public int Index { get; set; }
        public string Guid { get; set; }
        public bool IsActive { get; set; }
        public string Value { get; set; }
        public string Numerator { get; set; }
        public string ReferenceNumber { get; set; }
        public string Customer { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Registered { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public IList<string> Tags { get; set; }
        public IList<InvoiceElement> Elements{ get; set; }
    }
    public class InvoiceElement
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}