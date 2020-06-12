using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestStore.Models;

namespace TestStore.Controllers
{
    public class HomeController : Controller
    {        //private readonly ILogger<HomeController> _logger;

        private DataContext context;
        public HomeController(DataContext ctx)
        {
            context = ctx;
        }
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View(context.Products.First());
        }

    }
}