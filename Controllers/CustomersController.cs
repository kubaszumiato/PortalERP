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
        public ErpModels.Customer Get(int id)
        {
            ErpModels.Customer entity;

            using (StreamReader file = File.OpenText(@""))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    var o = (JObject) JToken.ReadFrom(reader);
                    entity = o.ToObject<ErpModels.Customer>();
                }
            }

            return entity;
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
