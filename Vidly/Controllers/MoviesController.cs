using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private SiteContext _context;
        public MoviesController()
        {
            _context = new SiteContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!",
            };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };



            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            //Second way:
            //var viewResult = new ViewResult
            //{
            //    ViewName = "Random",
            //    ViewData = new ViewDataDictionary<Movie>(ViewData, movie)
            //};
            //return viewResult;
            //viewResult.ViewData.Model = movie;

            //First way:
            return View(viewModel);



            //return Content("Hello World");
            //return NotFound("Not found ");
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortByName="name"});
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id = 1, Name = "Shrek"},
                new Movie{Id = 2, Name = "Smith"}
            };
        }

        //public ActionResult Add()
        //{
        //    using (var db = new SiteContext())
        //    {
        //        // Create and save a new Movie
        //        var movie = new Movie { Name = "A good movie" };
        //        db.Movies.Add(movie);
        //        db.SaveChanges();

        //        // Display all Movies from the database
        //        var query = from b in db.Movies
        //                    orderby b.Name
        //                    select b;

        //        return View(movie);
        //    }
        //}

        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }

        // Movies/Index 
        //public ActionResult Index(int? pageIndex, string sortBy)
        public ViewResult Index()
        {

            var movies = _context.Movies.Include(c => c.Genre).ToList();
            //ViewData["MovieName"] = "Shangqi";
            //ViewData["Customer"] = "Chen";
            return View(movies);

            /*
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("page Index={0}&sortBy={1}", pageIndex, sortBy));
            */
        }

        [Route(@"movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Details(int id) {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
    }
}
