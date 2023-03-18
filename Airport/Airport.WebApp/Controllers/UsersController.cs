using Airports.ViewModels.Models.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Airport.WebApp.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            List<IndexUserViewModel> users = new List<IndexUserViewModel>()
            {
                new IndexUserViewModel(){FirstName="Name 1",LastName="Name 1",Age=15 },
                new IndexUserViewModel(){FirstName="Name 1",LastName="Name 1",Age=15 },
                new IndexUserViewModel(){FirstName="Name 1",LastName="Name 1",Age=15 },
                new IndexUserViewModel(){FirstName="Name 1",LastName="Name 1",Age=15 }
            };

            return View(users);
        }
    }
}
