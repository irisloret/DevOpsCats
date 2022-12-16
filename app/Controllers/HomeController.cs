using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using catsProject.Models;
using Contentful.Core;

namespace catsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly  IContentfulClient _client;

        public HomeController(ILogger<HomeController> logger, IContentfulClient client)
        {
            _client = client;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CatInfo()
        {
            var cats = await _client.GetEntriesByType<Cat>("devOps");
            return View(cats);
        }

        public async Task<IActionResult> CatToys()
        {
            var toys = await _client.GetEntriesByType<Toy>("catToys");
            return View(toys);
        }

        public async Task<IActionResult> CatBeds()
        {
            var beds = await _client.GetEntriesByType<Bed>("catBeds");
            return View(beds);
        }

        public async Task<IActionResult> CatFood()
        {
            var foods = await _client.GetEntriesByType<Food>("catFood");
            return View(foods);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
