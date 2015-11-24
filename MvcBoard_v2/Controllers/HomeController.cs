using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBoard_v2.Models;

namespace MvcBoard_v2.Controllers
{
    public class HomeController : Controller
    {
        //private ChanContex _chanContext;
        public ActionResult Index()
        {
         // var _chanContext =  new ChanContex();
           // _chanContext.Boards.Add(new Board() {Name = "Бред", Threads = new List<Thread>()});
          //  _chanContext.SaveChanges();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}