using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDataBase.Models;

namespace MVCDataBase.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/ Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Fury!" };
            var customer = new List<Customer>


            {
                new Customer { Name ="Customer 1"},
                new Customer { Name ="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customer
            };      

            return View(viewModel);
        }
    }
}