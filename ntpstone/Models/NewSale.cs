using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ntpstone.Models;

namespace ntpstone.Models
{
    //3.Create Domain Model
    public class NewSale
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Quartz Quartz { get; set; }

        public string invoiceNum { get; set; }

        public DateTime saleDate { get; set; }

        public int saleQuantity { get; set; }

        public double unitPrice { get; set; }

        public double salePrice { get; set; }

        public double GST { get; set; }

        public double lineTotal { get; set; }

        public string paymentMethod { get; set; }

        public double shortCredit { get; set; }

        public double overCredit { get; set; }

        public string paymentInfo { get; set; }
    }
}