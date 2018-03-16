using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreTypesId {get;set;}
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate{get;set;}
        public DateTime AvailableDate{get;set;}        
        public GenreTypes GenreTypes {get;set;}
        [Display(Name = "Numbers in stock")]
        [Range(1,20)]
        public byte NumberInStock {get;set;}
        public byte NumberAvailable {get;set;}

    }
}