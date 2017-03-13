using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ntpstone.Models
{
    public class Quartz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string thickness { get; set; }
        public int ArrivalQuantity { get; set; }
        public int SaleQuantity { get; set; }
        public int StockQuantity { get; set; }
        public int ActualStockQuantity { get; set; }
        public int SaleQuantity2 { get; set; }
        public int HoldQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public string Color { get; set; }
    }
}