using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticalTest.Models;

namespace PracticalTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //using view data as a simple way of passing data to a view
            ViewData["BackgroundImage"] = Url.Content("~/images/background.jpg");
            ViewData["TextOne"] = "It Doesn't Take a Rocket Scientist.";
            ViewData["TextTwo"] = "IT TAKES A DESIGNER.";

            //working with models to handle more complex data operation 
            var model = new List<Item>();
            model.Add(new Item { Icon = Url.Content("~/images/icone.jpeg"), Title = "Design", Text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout." });
            model.Add(new Item { Icon = Url.Content("~/images/icone.jpeg"), Title = "Design", Text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout." });
            model.Add(new Item { Icon = Url.Content("~/images/icone.jpeg"), Title = "Design", Text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout." });

            return View(model);
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
