using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private RandomMovieViewModel vm = new RandomMovieViewModel()
        {
            Movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Star Wars"}
            },
            ViewName = "Movies"

        };

        //GET- movie details
        public ActionResult Details(int id)
        {
            return View(vm.Movies.Find(x => x.Id == id));
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            return View(vm); //<- Passing data as argument to view

           

            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortby = "name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        /// <summary>
        /// Example of attributed routing, multiple contraints are applied using regex on month
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{1}|d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}       