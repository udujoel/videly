using System.Web.Mvc;

using videly.Models;

namespace videly.Controllers {
    public class MoviesController :Controller {
        // GET: Movies/Random
        public ActionResult Random() {

            var movies = new Movie {
                Name = "Iron Man" ,
                Description = "Since time began, Cryptionites has been Iron Man's worst enemy and his enemies best friend. This has been over exploited in the past to a great extent."
                };
            return View(movies);

            }

        public ActionResult Edit(int moviesId) {


            return Content($"id = {moviesId}");
            }

        public ActionResult Index(int? pageIndex , string sortby) {

            if (!pageIndex.HasValue) {
                pageIndex = 1;
                }

            if (string.IsNullOrWhiteSpace(sortby)) {
                sortby = "Name";
                }
            return Content("Welcome");
            }

        public ActionResult ByReleaseDate(int year , int month) {
            return Content($"Year: {year}\tMonth: {month}");
            }
        }
    }