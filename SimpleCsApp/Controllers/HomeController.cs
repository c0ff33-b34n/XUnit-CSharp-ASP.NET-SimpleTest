using Microsoft.AspNetCore.Mvc;
using SimpleCsApp.Models;

namespace SimpleCsApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() {
            return View(Product.GetProducts());
        }
        
    }
}