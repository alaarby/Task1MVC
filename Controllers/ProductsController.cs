using Microsoft.AspNetCore.Mvc;
using Task1MVC.Data;

namespace Task1MVC.Controllers
{
    public class ProductsController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int Id) 
        {
            var product = context.Products.Find(Id);
            return View(product);
        }

    }
}
