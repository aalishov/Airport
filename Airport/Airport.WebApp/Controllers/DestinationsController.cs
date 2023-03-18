using Airports.ViewModels.Models.Destinations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Airport.WebApp.Controllers
{
    public class DestinationsController : Controller
    {
        public IActionResult Index()
        {
            List<DestinationIndexViewModel> models = new List<DestinationIndexViewModel>();
            return View(models);
        }
    }
}
