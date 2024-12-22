using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedPartialView.Models;

namespace StronglyTypedPartialView.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Products()
        {
            List<Product> products = new List<Product>() {
            new Product(){ Id=101,Name="Reebok Shoes",Description="Descrition 1", Price=1000.00,Image="/Images/1.jpg"},
            new Product(){ Id=102,Name="Reyben Glasses",Description="Descrition 1", Price=1000.00,Image="/Images/1.jpg"},
            new Product(){ Id=101,Name="Rolex Watch",Description="Descrition 1", Price=1000.00,Image="/Images/1.jpg"}

            };
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
