using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace ntpstone.Models
{
    public class MembershipType
    {
        public Byte Id { get; set; }
        public string Name { get; set; }
        public short SignFee { get; set; }
        public Byte DurationInMonths { get; set; }
        public Byte DiscountRate { get; set; }
        public Double DiscountRate2 { get; set; }
    }
}