using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    [RoutePrefix("movies")]
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET- movie details
        //[Route("{id?}")]
        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.GenreTypes).
                SingleOrDefault(m => m.Id == id);
            return View(movies);
            
        }
        // GET: Movies/List
        [Route]
        public ActionResult Movies()
        {
            var movies = _context.Movies.Include(mbox=> mbox.GenreTypes).ToList();
            return View(movies); //<- Passing data as argument to view

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