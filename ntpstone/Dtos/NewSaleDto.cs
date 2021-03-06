﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ntpstone.Models;


namespace ntpstone.Dtos
{
    //2.Create a NewSaleDto for the api SaleController
    public class NewSaleDto
    {
        public int CustomerId { get; set; }

        public List<int> QuartzIds { get; set; }

        public string invoiceNum { get; set; }

        //public DateTime saleDate { get; set; }

        public List<int> saleQuantity { get; set; }

        public List<double> unitPrice { get; set; }

        public List<double> salePrice { get; set; }

        public List<double> GST { get; set; }

        public List<double> lineTotal { get; set; }

        public string paymentMethod { get; set; }

        public double shortCredit { get; set; }

        public double overCredit { get; set; }

        public string paymentInfo { get; set; }
    }
}