using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBoard_v2.Models;

namespace MvcBoard_v2.Controllers
{
    
    public class ThreadController : Controller
    {
        ChanContex _chanContex  = new ChanContex();
        public ActionResult ShowThreads(int id)
        {
            
            return View();
        }
    }
}