#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviePages.Models;

namespace MoviePages.Data
{
    public class MoviePagesContext : DbContext
    {
        public MoviePagesContext (DbContextOptions<MoviePagesContext> options)
            : base(options)
        {
        }

        public DbSet<MoviePages.Models.Movie> Movie { get; set; }
    }
}
