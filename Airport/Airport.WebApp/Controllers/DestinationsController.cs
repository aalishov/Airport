using Airport.Services;
using Airports.ViewModels.Destinations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Airport.WebApp.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly DestinationsService destinationsService;

        public DestinationsController()
        {
            this.destinationsService = new DestinationsService();
        }
        public IActionResult Index(int page = 1)
        {
            DestinationsIndexViewModel models = new DestinationsIndexViewModel();
            models.PageNumber = page;
            models = destinationsService.GetDestinations(models);
            return View(models);
        }

        public IActionResult Search(int min, int max, int page = 1)
        {
            DestinationsSeacrhViewModel models = new DestinationsSeacrhViewModel();
            models.PageNumber = page;
            models.Min = min;
            models.Max = max;
            models.Action = "Search";
            models = destinationsService.GetDestinationsSearch(models);
             
            return View(models);
        }
        public IActionResult Cheapest()
        {
            List<DestinationIndexViewModel> model = destinationsService.GetChepestDestinations();
            return View(model);
        }

        public IActionResult Expensive()
        {
            List<DestinationIndexViewModel> model = destinationsService.GetMostExpensiveDestinations();
            return View(model);
        }

    }
}
