using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tema3.Models
{
    public class Movie
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string[] Actors { get; set; }
        public int[] Rates { get; set; }
        public int Price { get; set; }
        List<Movie> movies = new List<Movie>();
        public Movie(string Title, string Director, string Description = null, string[] Actors = null, int[] Rates = null, int Price = 0)
        {
            ID = Guid.NewGuid();
            this.Title = Title;
            this.Director = Director;
            this.Description = Description;
            this.Actors = Actors;
            this.Rates = Rates;
            this.Price = Price;
        }
    }
}
