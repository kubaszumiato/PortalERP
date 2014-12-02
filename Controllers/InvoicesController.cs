using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PortalERP.Models;

namespace PortalERP.Controllers
{
    public class InvoicesController : ApiController
    {
        // GET: api/Invoices
        public IEnumerable<ErpModels.Invoice> Get()
        {
            return InvoicesService.GetInvoices();
        }

        // GET: api/Invoices/5
        public ErpModels.Invoice Get(int id)
        {
            return InvoicesService.GetInvoice(id);
        }

        // POST: api/Invoices
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Invoices/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Invoices/5
        public void Delete(int id)
        {
        }
    }
}
