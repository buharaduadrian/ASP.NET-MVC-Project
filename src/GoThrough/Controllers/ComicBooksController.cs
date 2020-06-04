using GoThrough.Data;
using GoThrough.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoThrough.Controllers
{
    public class ComicBooksController:Controller
    {
        private ComicBookRepository _comicBookRepository=null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);
            return View(comicBook);
        }
    }
}