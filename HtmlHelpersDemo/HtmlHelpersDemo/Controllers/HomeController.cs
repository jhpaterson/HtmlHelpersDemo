using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersDemo.Models;

namespace HtmlHelpersDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            ViewBag.ProductName = "Onion";

            Product product = new Product { ProductID = 1, ProductName = "Banana", Description = "Yellow", Price = 9.99M };

            return View(product);
        }

        public ActionResult Grid()
        {
            IEnumerable<Product> products = new List<Product>{
                new Product{ProductID=1,ProductName="Banana",Description="Yellow",Price=9.99M},
                new Product{ProductID=2,ProductName="Apple",Description="Green",Price=9.99M},
                new Product{ProductID=3,ProductName="Orange",Description="Blue",Price=9.99M}
            };

            return View(products);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
