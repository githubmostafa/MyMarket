using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMarket.Models;

namespace MyMarket.Controllers
{
    public class foodController : Controller
    {
        private DBContext DB;
        public foodController()
        {
            DB = new DBContext();
        }
        protected override void Dispose(bool disposing)
        {
            DB.Dispose();
        }
        public ActionResult Index()
        {
            var fds = DB.foods.ToList();
            return View(fds);
        }
    }
}