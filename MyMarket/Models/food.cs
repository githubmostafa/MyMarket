using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace MyMarket.Models
{
    public class food
    {
        [Key]
        [StringLength(15, MinimumLength = 15)]
        public String Barcode { get; set; }

        [Display(Name = "Brand")]

        public String BrandName { get; set; }
        public int FoodTypeID { get; set; }
        [ForeignKey("FoodTypeID")]
        
        public virtual FoodType foodType { get; set; }
        [Display(Name = "Production")]

        public DateTime ProductionDate { get; set; }
        [Display(Name = "Expiry")]

        public DateTime ExpiryDate { get; set; }


    }
}