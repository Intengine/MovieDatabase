using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace IntengineMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IntengineMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<IntengineMovieContext>>()))
            {
                if(context.Movie.Any())
                {
                    return;
                }

                context.SaveChanges();
            }
        }
    }
}