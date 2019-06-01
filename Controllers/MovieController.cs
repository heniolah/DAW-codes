using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamenAngular.Models;
using ExamenAngular.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace ExamenAngular.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]/[action]")]
    public class MovieController: Controller
    {
        private readonly ExamenAngularContext _context;
        static List<Movie> movies = new List<Movie>()
        {
            new Movie() { Id = Guid.NewGuid(), Name = "movie1" },
            new Movie() { Id = Guid.NewGuid(), Name = "movie2" },
        };
        public MovieController(ExamenAngularContext context)
        {
            _context = context;
        }
        // GET: Movies
        public IActionResult Index()
        {
            return View(movies);
        }
        // GET: Movies/Details
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = movies.FirstOrDefault(db => db.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Duckbills/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }
        // GET: Duckbills/Delete
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Duckbills/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool MovieExists(Guid id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
