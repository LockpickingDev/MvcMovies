using Microsoft.EntityFrameworkCore; 
using MvcMovies.Models;

namespace MvcMovies.Data
{
    
    public class MvcMoviesContext : DbContext /*** Extend DbContext ***/
    {
        public MvcMoviesContext (DbContextOptions<MvcMoviesContext> options) : base(options) /*** Extend base ***/
        {

        }

        //Property for Entity set (typically a DB table).  Entity = row in data table
        public DbSet<Movie> Movie { get; set; } //Movie property used for Scaffolding of MoviesController 

    }
}
