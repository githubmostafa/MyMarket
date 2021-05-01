using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMarket.Models
{
    public class Market
    {
        [Key]
        public int TransactionID { get; set; }

        [StringLength(15, MinimumLength = 15)]
        public String Barcode { get; set; }
        [Display(Name = "Quantity")]

        public int QuantitySold { get; set; }
        [Display(Name = "Date Sold")]

        public DateTime DateTimeSold { get; set; }
        [Display(Name = "Total Price")]

        public int TotalPrice { get; set; }
    }
}