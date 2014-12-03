using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalERP.Models.Customers
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
}