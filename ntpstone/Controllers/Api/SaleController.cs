using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ntpstone.Dtos;

namespace ntpstone.Controllers.Api
{
    //1.Create a api controller for the sale function
    public class SaleController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateNewSale(NewSaleDto newSale)
        {
            throw new NotImplementedException();
        }
    }
}
