using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//passing our data repsository and model.
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


        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.getComicBooks();

            return View(comicBooks);

        }

        public ActionResult Detail(int? id)
        {

            if(id == null)
            {
                return HttpNotFound();
            }
           
            //We are collecting our comic book model from our repository.
            ComicBook comicBook = _comicBookRepository.GetComicBook((int)id);

           
          
            //passing our model to the view
            return View(comicBook);

           

        }
    }
}