using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMarket.Models
{
    public class FoodType
    {
        public int Id { get; set; }
        [Display(Name = "Food Type")]

        public String Foodtype { get; set; }
    }
}