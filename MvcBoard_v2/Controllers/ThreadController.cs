using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBoard_v2.Models;
using MvcBoard_v2.ViewModel;

namespace MvcBoard_v2.Controllers
{
    
    public class ThreadController : Controller
    {
        ChanContex _chanContex  = new ChanContex();
        public ActionResult ShowThreads(int id)
        {
            var firstOrDefault = _chanContex.Boards.FirstOrDefault(x => x.id == id);
            if (firstOrDefault != null)
            {
                var threads = firstOrDefault.Threads;
                ShowThreadsModel showThreadsModel = new ShowThreadsModel() {BoardId = id, Threads = threads};

                return View(showThreadsModel);
            }
            return Redirect("/Board/ShowBoards");
        }
        [HttpPost]
        public ActionResult Create(AddThreadModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("ShowThreads", model.BoardId);
            }
            var threadAdded = new Thread() {Posts = new List<Post>(), BoardId = model.BoardId};
            var postAdded = new Post() { Email = model.Email,Message = model.Message,ThreadId = threadAdded.id, }
            _chanContex.Threads.Add(new Thread() {Posts = new List<Post>(), BoardId = model.BoardId});
            
            return View();
        }
    }
}