using System.Web.Mvc;

using videly.Models;

namespace videly.Controllers {
    public class MoviesController :Controller {
        // GET: Movies/Random
        public ActionResult Random() {

            var movies = new Movie {
                Name = "Iron Man"
                };
            return View();
            }
        }
    }