using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PortalERP.Models;

namespace PortalERP.Controllers
{
    public class CustomersController : ApiController
    {
        // GET: api/Customers
        public IEnumerable<ErpModels.Customer> Get()
        {
            object c = new object();
            return (IEnumerable<ErpModels.Customer>)c;

        }

        // GET: api/Customers/5
        public string Get(int id)
        {
            return "value";
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
