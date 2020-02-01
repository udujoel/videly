using System.Collections.Generic;
using System.Web.Mvc;

using videly.Models;
using videly.ViewModels;

namespace videly.Controllers {
    public class MoviesController :Controller {
        // GET: Movies/Random
        public ActionResult Random() {

            var movie = new Movie {
                Name = "Iron Man" ,
                Description = "Since time began, Cryptionites has been Iron Man's worst enemy and his enemies best friend. This has been over exploited in the past to a great extent."
                };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel {
                Movie = movie ,
                Customers = customers
                };
            return View(viewModel);

            }

        }
    }