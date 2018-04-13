using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticalTest.Models;

namespace PracticalTest.Controllers.Product
{
    public class ProductController : Controller
    {
        private List<PracticalTest.Models.Product> listOfProducts;

        public IActionResult Product()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Details(int? id)
        {
            LoadListofProducts();//hardcoded generating data
            if (id == null)
            {
                //return NotFound();
            }
            var model = listOfProducts.Find((Models.Product obj) => obj.Id == id);
            return View(model);
        }

        private void LoadListofProducts()
        {
            listOfProducts = new List<PracticalTest.Models.Product>();
            //hardcoding generating two products
            List<string> mylist = new List<string>(new string[] { "element1", "element2", "element3" });
            listOfProducts.Add(new Models.Product { Id = 1, Title = "PRODUCT 01", Headline = "Beautiful on every device", Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.", Characteristics = mylist, Image = Url.Content("~/images/product1.jpg") });
            listOfProducts.Add(new Models.Product { Id = 2, Title = "PRODUCT 02", Headline = "Ugly on every device", Description = " If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.", Characteristics = mylist, Image = Url.Content("~/images/product2.jpg") });
        }

    }
}
