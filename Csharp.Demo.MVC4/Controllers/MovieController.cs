using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Csharp.Demo.MVC4.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            ViewBag.Name = "奇幻深林";
            ViewBag.Time = "2016";
            return View();
        }

        public string GetMovieName()
        {
            return "奇幻森林";
        }

        public JsonResult GetMovieJsonData()
        {

        }

    }
}