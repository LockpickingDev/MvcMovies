using Microsoft.EntityFrameworkCore; 
using MvcMovies.Models;

namespace MvcMovies.Data
{
    
    public class MvcMoviesContext : DbContext /*** Extend DbContext ***/
    {
        public MvcMoviesContext (DbContextOptions<MvcMoviesContext> options) : base(options) /*** Extend base ***/
        {

        }

        public DbSet<Movie> Movie { get; set; } //Property for Entity set (typically a DB table).  Entity = row in data table

    }
}
