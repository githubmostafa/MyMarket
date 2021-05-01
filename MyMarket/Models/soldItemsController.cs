using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMarket.Models
{
    public class soldItemsController : Controller
    {
        private DBContext DB;
        public soldItemsController()
        {
            DB = new DBContext();
        }
        protected override void Dispose(bool disposing)
        {
            DB.Dispose();
        }
        public ActionResult Index()
        {
            var sld = DB.markets.ToList();
            return View(sld);
        }
    }
}