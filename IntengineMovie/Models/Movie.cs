using System;

namespace IntengineMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime releaseDate { get; set; }
        public string genre { get; set; }
        public decimal price { get; set; }
    }
}