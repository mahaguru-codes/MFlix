using MFlix.Models.Beans;
using MFlix.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MFlix.Controllers
{
    [Route("api/[Controller]")]
    public class MovieController : Controller
    {
        [Route("movies")]
        public IActionResult Movie()
        {
            var movies = new List<Movie>()
            {
                new Movie() { Id = 1, Name = "Harry Potter and Philosopher's Stone" },
                new Movie() { Id = 2, Name = "Ravening" },
                new Movie() { Id = 3, Name = "Girl in the Basement" },
                new Movie() { Id = 4, Name = "Wrath of Vajra" }
            };

            return View(movies);
        }

        public IActionResult Detail(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);

            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Id = 1, Name = "Harry Potter and Philosopher's Stone" },
                new Movie() { Id = 2, Name = "Ravening" },
                new Movie() { Id = 3, Name = "Girl in the Basement" },
                new Movie() { Id = 4, Name = "Wrath of Vajra" }
            };
        }
    }
}
