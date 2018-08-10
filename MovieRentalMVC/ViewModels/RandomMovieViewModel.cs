using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRentalMVC.Models;

namespace MovieRentalMVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}