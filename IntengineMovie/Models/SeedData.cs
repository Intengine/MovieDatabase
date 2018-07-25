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

                context.Movie.AddRange(
                    new Movie
                    {
                        title = "The Godfather",
                        releaseDate = DateTime.Parse("1972-08-12"),
                        genre = "Drama",
                        price = 49.99M
                    },
                    
                    new Movie
                    {
                        title = "Scarface",
                        releaseDate = DateTime.Parse("1980-12-02"),
                        genre = "Action",
                        price = 39.89M
                    },

                    new Movie
                    {
                        title = "Rio Bravo",
                        releaseDate = DateTime.Parse("1959-4-15"),
                        genre = "Western",
                        price = 28.79M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}