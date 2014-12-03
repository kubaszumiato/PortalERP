using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PortalERP.Models;
using PortalERP.Models.Invoices;

namespace PortalERP.Services
{
    public class InvoicesService
    {
        private static List<Invoice> _invoices;

        public InvoicesService()
        {
            _invoices = new List<Invoice>();
        }

        public static Invoice GetEmptyInvoice()
        {
            var invoice = new Invoice();
            invoice.Elements = new List<InvoiceElement>();
            return invoice;
        }

        public static Invoice GetInvoice(string id)
        {
            return _invoices.FirstOrDefault(invoice => invoice.Id == id);
        }

        public static List<Invoice> GetInvoices()
        {
            _invoices = new List<Invoice>();

            var path = HttpContext.Current.Server.MapPath("~/Content/StaticFiles/JSON/invoices.json");
            using (var streamReader = File.OpenText(path))
            {
                
                var invoicesFromFile = streamReader.ReadToEnd();
                var jsonInvoices = (Newtonsoft.Json.Linq.JArray)JsonConvert.DeserializeObject(invoicesFromFile);
                
                foreach (dynamic ob in jsonInvoices)
                {
                    var invoice = GetEmptyInvoice();

                    invoice.Id = ob._id;
                    invoice.Index = ob.index;
                    invoice.Customer = ob.custom;
                    invoice.Address = ob.address;
                    invoice.Phone = ob.phone;
                    invoice.Description = ob.description;
                    invoice.Latitude = ob.latitude;
                    invoice.Longitude = ob.longitude;
                    invoice.Registered = ob.registered;
                    invoice.ReferenceNumber = ob.referenceNumber;
                    invoice.Numerator = ob.numerator;
                    invoice.Value = ob.value;
                    invoice.Guid = ob.guid;
                    invoice.IsActive = ob.isActive;


                    foreach (dynamic item in ob.items)
                    {
                        invoice.Elements.Add(
                            new InvoiceElement()
                            {
                                Code = item.code,
                                Id = item.id,
                                Name = item.name,
                                Price = item.price,
                                Quantity = item.quantity
                            });
                    }
                    _invoices.Add( invoice );
                }
            }
            return _invoices;
        }

    }
}