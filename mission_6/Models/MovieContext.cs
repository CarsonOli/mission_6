using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mission_6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
    }

}
