using DaMovies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Collection.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DaMovies.Models.Database_Set _someContext { get; set; }

        // constructor
        public HomeController(ILogger<HomeController> logger, DaMovies.Models.Database_Set someName)
        {
            _logger = logger;
            _someContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        //added this to be the My_Podcasts Action
        public IActionResult My_Podcasts()
        {
            return View("My_Podcasts");
        }

       //added this for the movie form
       [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Movies = _someContext.MovieCategory.ToList();

            return View();
        }
        //and this to go to the confimation page
        [HttpPost]
        public IActionResult MovieForm(FormClass response)
        {
            if (ModelState.IsValid)
            {
                _someContext.Add(response);
                _someContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Movies = _someContext.MovieCategory.ToList();
                return View(response);
            }

            
        }

        //View All movies methods/classes here down


        [HttpGet]
        public IActionResult AllMovies()
        {
            var allmovies = _someContext.reponse
            .Include(x => x.Category)   /*not sure about this part*/
            .ToList();

            return View(allmovies);
        }

        ////now on to edit

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Movies = _someContext.MovieCategory.ToList();

            var application = _someContext.reponse.Single(x => x.MovieID == movieid);

            return View("MovieForm", application);
        }

        [HttpPost]
        public IActionResult Edit(FormClass ugg)
            {
            _someContext.Update(ugg);
            _someContext.SaveChanges();

            return RedirectToAction("AllMovies");
            }

        //now on to delete

        [HttpGet]
        public IActionResult Delete(int movieID)
        {
           var application = _someContext.reponse.Single(x => x.MovieID == movieID);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(FormClass fc)
        {
            _someContext.reponse.Remove(fc);
            _someContext.SaveChanges();

            return RedirectToAction("AllMovies");
        }






    }
}
