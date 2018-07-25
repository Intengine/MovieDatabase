using Microsoft.EntityFrameworkCore;

namespace IntengineMovie.Models
{
    public class IntengineMovieContext : DbContext
    {
        public IntengineMovieContext (DbContextOptions<IntengineMovieContext> options)
            : base(options)
        {
        }

        public DbSet<IntengineMovie.Models.Movie> Movie { get; set; }
    }
}