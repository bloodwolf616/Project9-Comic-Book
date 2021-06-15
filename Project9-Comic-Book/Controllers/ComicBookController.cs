using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project9_Comic_Book.Data;
using Project9_Comic_Book.Models;

namespace Project9_Comic_Book.Controllers
{
    public class ComicBookController : Controller
    {

        private ComicBookRepository _comicBookRepository = null;


        //constructor. 
        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {

            if(id == null)
            {
                return HttpNotFound();
            }
            ComicBook comicBook = _comicBookRepository.GetComicBook((int)id);

           
          

            return View(comicBook);

           

        }
    }
}