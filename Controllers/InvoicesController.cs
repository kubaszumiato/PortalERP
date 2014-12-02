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
            System.Configuration.Configuration rootWebConfig1 =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(null);
            if (rootWebConfig1.AppSettings.Settings.Count > 0)
            {
                System.Configuration.KeyValueConfigurationElement customSetting =
                    rootWebConfig1.AppSettings.Settings["customsetting1"];
                if (customSetting != null)
                    Console.WriteLine("customsetting1 application string = \"{0}\"",
                        customSetting.Value);
                else
                    Console.WriteLine("No customsetting1 application string");
            }
            return new string[] { "value1", "value2" };

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
