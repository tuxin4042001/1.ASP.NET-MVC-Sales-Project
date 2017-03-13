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
            if (newSale.QuartzIds.Count == 0)
            {
                return BadRequest("No Quartz Ids is given.");
            }

            var customer = _context2.Customers.SingleOrDefault(c => c.Id == newSale.CustomerId);
            if(customer == null)
            {
                return BadRequest("CustomerId is invalid.");
            }

            var quartzs = _context2.Quartzs.Where(m => newSale.QuartzIds.Contains(m.Id)).ToList();
            if(quartzs.Count != newSale.QuartzIds.Count)
            {
                return BadRequest("One or more quartz are invalie.");
            }

            for(int i = 0; i < quartzs.Count; i++)
            {
                if(quartzs[i].AvailableQuantity == 0)
                {
                    return BadRequest("Quartz is not available.");
                }

                quartzs[i].SaleQuantity = quartzs[i].SaleQuantity + newSale.saleQuantity[i];
                quartzs[i].StockQuantity = quartzs[i].StockQuantity - newSale.saleQuantity[i];
                quartzs[i].AvailableQuantity = quartzs[i].AvailableQuantity - newSale.saleQuantity[i];
                var sale = new NewSale
                {
                    Customer = customer,
                    Quartz = quartzs[i],
                    invoiceNum = newSale.invoiceNum,
                    saleDate = DateTime.Now,
                    saleQuantity = newSale.saleQuantity[i],
                    unitPrice = newSale.unitPrice[i],
                    salePrice = newSale.salePrice[i],
                    GST = newSale.saleQuantity[i] * newSale.salePrice[i] * 0.05,
                    lineTotal = newSale.saleQuantity[i] * newSale.salePrice[i] * 1.05,
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
