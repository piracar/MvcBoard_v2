using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBoard_v2.Models;
using MvcBoard_v2.ViewModel;

namespace MvcBoard_v2.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        readonly ChanContex _chanContext = new ChanContex();

        public BoardController()
        {
            _chanContext = new ChanContex();
        }
        public ActionResult ShowBoards()
        {
            ShowBoardsModel showBoardsModel = new ShowBoardsModel() {Boards = _chanContext.Boards.ToList()};
            return View(showBoardsModel);
        }

        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult Create(AddBoardModel model)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/Board/ShowBoards");
            }
            var board = new Board() {Name = model.Name.ToLower()};
            _chanContext.Boards.Add(board);
            _chanContext.SaveChanges();
            return Redirect("Board/ShowBoards");
        }
    }
}