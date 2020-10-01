using Microsoft.AspNetCore.Mvc;
using SimpleCsApp.Models;

namespace SimpleCsApp.Controllers
{
    public class HomeController : Controller
    {
        public IDataSource dataSource = new ProductDataSource();

        public ViewResult Index() {
            return View(dataSource.Products);
        }
        
    }
}