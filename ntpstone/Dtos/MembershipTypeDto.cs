using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ntpstone.Dtos
{
    public class MembershipTypeDto
    {
        public Byte Id { get; set; }
        public string Name { get; set; }
        public short SignFee { get; set; }
        public Byte DurationInMonths { get; set; }
        public Byte DiscountRate { get; set; }
        public Double DiscountRate2 { get; set; }
    }
}