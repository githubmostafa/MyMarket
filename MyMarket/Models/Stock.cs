using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Windows.Input;

namespace MyMarket.Models
{
    public class Stock
    {
        [Key]
        public int ItemId { get; set; }

        [StringLength(15, MinimumLength = 15)]
        public String Barcod { get; set; }
        [Display(Name = "Quantity Sold")]

        public int Quantity { get; set; }
        [Display(Name = "Price/Unit")]

        public float PricePerUnit { get; set; }
    }
}