using firstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppdbContext _db;
        public MovieController(AppdbContext _db) {
            this._db = _db;
                }
        public IActionResult Index()
        {
            Movie m = new Movie(1,"");  
           /* List<Movie> Movies = new List<Movie>() 
            {
                new Movie { id = 1, name = "movie1" },
                new Movie { id = 2, name = "movie1" }
            };*/
           var movies= _db.Movies.ToList();
            return View(movies);
        }
        public IActionResult Index2()
        {
            Movie m = new Movie(1, "");
            /* List<Movie> Movies = new List<Movie>() 
             {
                 new Movie { id = 1, name = "movie1" },
                 new Movie { id = 2, name = "movie1" }
             };*/
            var movies = _db.Movies.ToList();
            return View(movies);
        }
        public IActionResult Edit(int id)
		{
            return Content("testid"+id);
        }
        public IActionResult Delete(int id)
        {
            var movieToDelete = _db.Movies.Find(id);

            if (movieToDelete == null)
            {
                return NotFound();
            }

            _db.Movies.Remove(movieToDelete);
            _db.SaveChanges();

            return RedirectToAction("Index2");
        }
    }
}
