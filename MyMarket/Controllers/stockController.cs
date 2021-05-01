using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMarket.Models;
namespace MyMarket.Controllers
{
    public class stockController : Controller
    {
        private DBContext DB;
        public stockController()
        {
            DB = new DBContext();
        }
        protected override void Dispose(bool disposing)
        {
            DB.Dispose();
        }
        public ActionResult Index()
        {
            var stk = DB.stocks.ToList();
            return View(stk); ;
        }
    }
}