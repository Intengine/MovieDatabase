using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntengineMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Title")]
        public string title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime releaseDate { get; set; }

        [Display(Name = "Genre")]
        public string genre { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal price { get; set; }
    }
}