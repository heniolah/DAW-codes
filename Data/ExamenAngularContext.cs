using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ExamenAngular.Data
{
    public class ExamenAngularContext : IdentityDbContext
    {
        public ExamenAngularContext(DbContextOptions<ExamenAngularContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Value> Values { get; set; }
        public DbSet<ExamenAngular.Models.Movie> Movie { get; set; }
    }
}
