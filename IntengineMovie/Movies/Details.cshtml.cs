using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IntengineMovie.Models;

namespace IntengineMovie.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly IntengineMovie.Models.IntengineMovieContext _context;

        public DetailsModel(IntengineMovie.Models.IntengineMovieContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.SingleOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}