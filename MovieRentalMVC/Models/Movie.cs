using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieRentalMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte NumberInStock { get; set; }

        //Ref. Genre table
        [Required]
        public Genre Genre { get; set; }    //Ref to Genre table
        public byte GenreId { get; set; }   //FK
      

    }
}