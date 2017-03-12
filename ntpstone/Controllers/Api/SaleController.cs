using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ntpstone.Dtos;
using ntpstone.Models;

namespace ntpstone.Controllers.Api
{
    //1.Create a api controller for the sale function
    //5.Create a simplest api controller
    public class SaleController : ApiController
    {
        private ApplicationDbContext _context2;

        public SaleController()
        {
            _context2 = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewSale(NewSaleDto newSale)
        {
            var customer = _context2.Customers.SingleOrDefault(c => c.Id == newSale.CustomerId);

            var quartzs = _context2.Quartzs.Where(m => newSale.QuartzIds.Contains(m.Id)).ToList();

            foreach (var quartz in quartzs)
            {
                var sale = new NewSale
                {
                    Customer = customer,
                    Quartz = quartz,
                    invoiceNum = newSale.invoiceNum,
                    saleDate = DateTime.Now,
                    saleQuantity = newSale.saleQuantity,
                    unitPrice = newSale.unitPrice,
                    salePrice = newSale.salePrice,
                    GST = newSale.GST,
                    lineTotal = newSale.lineTotal,
                    paymentMethod = newSale.paymentMethod,
                    shortCredit = newSale.shortCredit,
                    overCredit = newSale.overCredit,
                    paymentInfo = newSale.paymentInfo
                };

                _context2.NewSales.Add(sale);
            }

            _context2.SaveChanges();

            return Ok();
        }
    }
}
