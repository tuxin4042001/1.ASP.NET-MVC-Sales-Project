﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ntpstone.Models;

namespace ntpstone.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(225)]
        public string Name { get; set; }

        [Required]
        [StringLength(225)]
        public string Address { get; set; }

        [Required]
        [StringLength(225)]
        [RegularExpression("[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]",ErrorMessage = "Invalid Zip Code")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(225)]
        [RegularExpression("^[0-9]{3}[-.]?[0-9]{3}[-.]?[0-9]{4}$", ErrorMessage = "Invalid Cell Phone Number")]
        [Display(Name = "Cell Phone Number")]
        public string CellPhoneNumber { get; set; }

        [RegularExpression("^[0-9]{3}[-.]?[0-9]{3}[-.]?[0-9]{4}$", ErrorMessage = "Invalid Office Phone Number")]
        [Display(Name = "Office Phone Number")]
        public string OfficeNumber { get; set; }

        [Required]
        [StringLength(225)]
        public string City { get; set; }

        [Required]
        [StringLength(225)]
        public string District { get; set; }

        [StringLength(255)]
        [RegularExpression("@^(http\\:\\/\\/|https\\:\\/\\/)?([a-z0-9][a-z0-9\\-]*\\.)+[a-z0-9][a-z0-9\\-]*$@i", ErrorMessage = "Invalid Website Address")]
        public string WebSite { get; set; }

        [StringLength(255)]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public bool isFirstTimeBuyer { get; set; }

        [Required]
        [StringLength(225)]
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Required]
        [Display(Name = "Consumption Amount")]
        public double ConsumptionAmount { get; set; }

        public MembershipType MembershipType { get; set; }

        public Byte MembershipTypeId { get; set; }
    }
}