using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mission_6.Models;

namespace mission_6.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _movieContext;
        public HomeController(MovieContext temp)
        {
            _movieContext = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Submit_Movie()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit_Movie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _movieContext.Movies.Add(movie);
            await _movieContext.SaveChangesAsync();

            return RedirectToAction(nameof(Submit_Movie));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
