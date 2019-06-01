using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExamenAngular.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty! Please provide a value!")]
        public string Name { get; set; }
    }
}
