using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project9_Comic_Book.Controllers
{
    public class RandomPageController : Controller
    {
        // GET: RandomPage
        public ActionResult Index()
        {
            ViewBag.GroceryList = new string[] { "Apples", "Oranges", "Bananas" };
            return View();
        }
    }
}