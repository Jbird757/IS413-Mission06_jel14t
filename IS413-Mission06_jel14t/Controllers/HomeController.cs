using IS413_Mission06_jel14t.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Mission06_jel14t.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext x)
        {
            _logger = logger;
            _movieContext = x;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View(new MovieEntryModel());
        }

        [HttpPost]
        public IActionResult AddMovie(MovieEntryModel response)
        {
            MovieEntryModel movie = response;
            if (ModelState.IsValid)
            {
                _movieContext.Add(response);
                _movieContext.SaveChanges();
                return RedirectToAction("AddMovie");
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();
                return View(response);
            }
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var dbEntries = _movieContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.title)
                .ToList();
            return View(dbEntries);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();
            MovieEntryModel movie = _movieContext.responses.Single(x => x.EntryID == id);

            return View("AddMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieEntryModel response)
        {
            if (ModelState.IsValid)
            {
                _movieContext.responses.Update(response);
                _movieContext.SaveChanges();
                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();
                return View(response);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            MovieEntryModel model = _movieContext.responses.Single(x => x.EntryID == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(MovieEntryModel response)
        {
            _movieContext.responses.Remove(response);
            _movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
