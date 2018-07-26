using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IntengineMovie.Models;

namespace IntengineMovie.Movies
{
    public class IndexModel : PageModel
    {
        private readonly IntengineMovie.Models.IntengineMovieContext _context;

        public IndexModel(IntengineMovie.Models.IntengineMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }

        public async Task OnGetAsync(string movieGenre, string searchString)
        {
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.genre
                                            select m.genre;

            var movies = from m in _context.Movie
                         select m;

            if(!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.title.Contains(searchString));
            }

            if(!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.genre == movieGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}