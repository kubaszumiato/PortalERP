using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PortalERP.Models;
using PortalERP.Models.Customers;
using PortalERP.Services;

namespace PortalERP.Controllers
{
    public class CustomersController : ApiController
    {
        // GET: api/Customers
        public IEnumerable<Customer> Get()
        {
            return CustomersService.GetCustomers();
        }

        // GET: api/Customers/5
        public Customer Get(string id)
        {
            return CustomersService.GetCustomer(id);
        }

        // POST: api/Customers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
    }
}
