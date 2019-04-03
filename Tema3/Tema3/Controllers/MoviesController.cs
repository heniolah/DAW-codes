using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tema3.Models;

namespace Tema3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        static List<Movie> movies = new List<Movie>()
        {
            new Movie("Title1","Director1"),
            new Movie("Title2","Director2"),
            new Movie("Title3","Director3")
        };

        // GET api/values
        [HttpGet]
        public Movie[] Get()
        {
            return movies.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Movie Get(Guid id)
        {
            return movies.FirstOrDefault(Movies => Movies.ID == id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            movie.ID = Guid.NewGuid();
            movies.Add(movie);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute]Guid id, [FromBody] Movie movie)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            Movie dbMovie = movies.FirstOrDefault(Movies => Movies.ID == id);
            dbMovie.ID = movie.ID;
            dbMovie.Title = movie.Title;
            dbMovie.Actors = movie.Actors;
            dbMovie.Director = movie.Director;
            dbMovie.Description = dbMovie.Description;
            dbMovie.Rates = movie.Rates;
            dbMovie.Price = movie.Price;

            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]Guid id)
        {
            movies.Remove(movies.FirstOrDefault(Movies => Movies.ID == id));
            return Ok();
        }
    }
}
