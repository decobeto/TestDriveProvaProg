using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestDrive.Models;

namespace TestDrive.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View("RsvpForm");
        }

        [HttpPost]
        public ViewResult RsvpForm(TesteDrive testeDrive)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(testeDrive);
                return View("ListResponses", Repository.responses);
            }
            else
            {
                return View(testeDrive);
            }
        }
    }
}
