using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var comicBooks = FirstChallenge.Models.ComicBookManager.GetComicBooks();
            return View(comicBooks);
        }

        // GET: Details
        public ActionResult Details(int? id)
        {
            var comicBooks = FirstChallenge.Models.ComicBookManager.GetComicBooks();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var comicBook = comicBooks.Find(p => p.ComicBookId == id);
            if (comicBook == null)
            {
                return HttpNotFound();
            }
            return View(comicBook);
        }
    }
}