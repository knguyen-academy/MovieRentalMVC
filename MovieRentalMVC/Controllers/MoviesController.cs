using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalMVC.Models;
using MovieRentalMVC.ViewModels;
namespace MovieRentalMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        //Get List of movie
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Name="Shrek" },
                new Movie {Id=2, Name="Ironman"}
            };
        }

        //Test 
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Ironman" };
            var customers = new List<Customer>
            {
                new Customer { Name ="Customer 1"},
                new Customer { Name ="Customer 2"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

        }

        //movies/edit/{id}
        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        //movies/released/year/month, see route.config
        // new way to define route, month contraint to 2 digits and 1-12
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer {Id=1, Name="John Smith" },
                new Customer {Id=2, Name ="Lara Ngo"}
            };

            return View(customers);
        }

        public ActionResult Movies()
        {
            var movies = new Movie() { Name = "Shrek" };
            return View(movies);
        }
    }
}