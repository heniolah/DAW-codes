using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExamenAngular.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] movieTitles = new[]
        {
            "The Pianist", "Matrix", "Forrest Gump", "Kill Bill", "Titanic", "The Greatest Showman","Ten Little Indians", "Something else", "Something New","Surprise"
        };
        private static string[] movieDirectors = new[]
        {
            "Steven Spielberg", "Albert Hitchcock", "Stanley Kubrick", "Quentin Tarantino", "James Cameron", "Somebody1", "Somebody2", "Somebody3","Somebody4", "Somebody5"
        };

        [HttpGet("[action]")]
        public IEnumerable<Movie> Movies()
        {
            var rnd = new Random();
            int i = 0, j = 0;
            do
            {
                return Enumerable.Range(1, 5).Select(index => new Movie
                {
                    MovieID = index.ToString(),
                    Title = movieTitles[i++],
                    Director = movieDirectors[j++],
                    TicketPrice = rnd.Next(10, 31).ToString(),
                });
            }
            while (i < 5 && j < 5);
        }

        public class Movie
        {
            public string MovieID { get; set; }
            public string Title { get; set; }
            public string Director { get; set; }

            public string TicketPrice { get; set; }
        }
    }
}
