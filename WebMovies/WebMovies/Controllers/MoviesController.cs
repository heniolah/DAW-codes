using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMovies.Models;
using Microsoft.AspNetCore.Http;

namespace WebMovies.Controllers
{
    public class MoviesController : Controller
    {
        static List<Movie> movies = new List<Movie>()
        {
            new Movie("Title1","Director1"),
            new Movie("Title2","Director2"),
            new Movie("Title3","Director3")
        };
        public IActionResult Index()
        {
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = movies.FirstOrDefault(Movies => Movies.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies
        public IActionResult Create()
        {
            return View();
        }
        // GET: Movies/Create
        public async Task<IActionResult> Create([Bind("Id,Name")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.ID = Guid.NewGuid();

                movies.Add(movie);

                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }
        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Movie movie = new Movie("newTitle", "newDirector");
                movie.ID = Guid.NewGuid();
                movies.Add(movie);
                movie.ID = movie.ID;
                movie.Title = movie.Title;
                movie.Actors = movie.Actors;
                movie.Director = movie.Director;
                movie.Description = movie.Description;
                movie.Rates = movie.Rates;
                movie.Price = movie.Price;
                collection.ElementAtOrDefault(Convert.ToInt32(movie.ID));
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }
        // GET: Movies/Edit
        public async Task<IActionResult> Edit(Guid id)
        {
            Movie movie = movies.FirstOrDefault(Movie => Movie.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        // POST: Movies/Edit
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                Movie movie = movies.FirstOrDefault(Movie => Movie.ID.Equals(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Movies/Delete
        public async Task<IActionResult> Delete(Guid id)
        {
            Movie movie = movies.FirstOrDefault(Movie => Movie.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        // POST: Movies/Delete
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                movies.Remove(movies.FirstOrDefault(movie => movie.ID.Equals(id)));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
