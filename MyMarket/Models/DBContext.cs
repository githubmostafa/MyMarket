using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyMarket.Models;

namespace MyMarket.Models
{
    public class DBContext:DbContext
    {
        public DBContext()
        {

        }
        public DbSet<food>foods { get; set; }
        public DbSet<Market> markets { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<FoodType> foodTypes { get; set; }

    }
}