using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}