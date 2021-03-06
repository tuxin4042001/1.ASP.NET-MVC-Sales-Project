﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ntpstone.Dtos
{
    public class QuartzDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string thickness { get; set; }
        public int ArrivalQuantity { get; set; }
        public int SaleQuantity { get; set; }
        public int StockQuantity { get; set; }
        public int ActualStockQuantity { get; set; }
        public string Color { get; set; }
    }
}