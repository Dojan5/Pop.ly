using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pop.ly.Models.Database
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        //Changes the display
        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        //Sets the maximum range. 
        [Range(0,5)]
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public string CoverArt { get; set; }
        public string PromoArt { get; set; }
        public string TrailerURL { get; set; }
    }
}