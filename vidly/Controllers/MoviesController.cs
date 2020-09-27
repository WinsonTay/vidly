using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }
        public ActionResult edit(int movieId)
        {
            return Content("id=" + movieId);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            
            if (String.IsNullOrEmpty(sortBy))
                sortBy = "Name";

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        //AttributeRoutes
        [Route("/movies/release/{year}/{month:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }

        
    }
}