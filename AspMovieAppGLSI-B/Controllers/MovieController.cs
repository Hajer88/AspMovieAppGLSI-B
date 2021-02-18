using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspMovieAppGLSI_B.Models;

namespace AspMovieAppGLSI_B.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movie = new Movie() { Name="Movie 1"};
            var movies = new List<Movie>()
            {
                new Movie{Name="Movie 1"},
                new Movie{Name="Movie 2"}
            };
            //return Content("Hello World");
            //return RedirectToAction("Index", "Home");
            //return HttpNotFound();
           return View(movies);
        }
        //Movie/Edit/1
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
        //Movie/ByReleaseDate/2020/03 
        //[Route("movies/released/{year}/{month:regex(range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year +"/"+ month);
        //}
    }
}