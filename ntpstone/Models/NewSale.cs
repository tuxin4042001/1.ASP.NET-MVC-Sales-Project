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

        [Required]
        public string invoiceNum { get; set; }

        [Required]
        public DateTime saleDate { get; set; }

        [Required]
        public int saleQuantity { get; set; }

        [Required]
        public double unitPrice { get; set; }

        [Required]
        public double salePrice { get; set; }

        public double GST { get; set; }

        public double lineTotal { get; set; }

        [Required]
        public string paymentMethod { get; set; }

        public double shortCredit { get; set; }

        public double overCredit { get; set; }

        public string paymentInfo { get; set; }
    }
}