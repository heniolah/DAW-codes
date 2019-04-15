using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebMoviesAngular.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        public Random rnd = new Random();
        private static string[] movieTitles = new[]
        {
            "The Pianist", "Matrix", "Forrest Gump", "Kill Bill", "Titanic", "The Greatest Showman","Ten Little Indians", "Something else", "Something New","Surprise"
        };
        private static string[] movieDirectors = new[]
        {
            "Steven Spielberg", "Albert Hitchcock", "Stanley Kubrick", "Somebody1", "Somebody2", "Somebody3","Somebody4", "Somebody5", "Somebody6","Somebody7"
        };

        [HttpGet("[action]")]
        public IEnumerable<Movie> Movies()
        {
            int ID = rnd.Next(50);
            return Enumerable.Range(1, 5).Select(index => new Movie
            {
                movieID = index,
                Title = movieTitles.SyncRoot.ToString(),
                Director = movieDirectors.SyncRoot.ToString(),
            });
        }

        public class Movie
        {
            public int movieID { get; set; }
            public string Title { get; set; }
            public string Director { get; set; }
            public Random rnd = new Random();
            public int TicketPrice
            {
                get
                {
                    return rnd.Next(10, 31);
                }
                set { movieID = value; }
            }
        }
    }
}
