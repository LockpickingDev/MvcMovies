using Microsoft.EntityFrameworkCore; 
using MvcMovies.Models;

namespace MvcMovies.Data
{
    
    public class MvcMoviesContext : DbContext /*** Extend DbContext ***/
    {
        public MvcMoviesContext (DbContextOptions<MvcMoviesContext> options) : base(options) /*** Extend base ***/
        {

        }

        //Movie Property for Entity set (DB table).  Property used in Scaffolding of MoviesController
        public DbSet<Movie> Movie { get; set; } //DbSet of Movie Model to create Movie property.

    }
}
