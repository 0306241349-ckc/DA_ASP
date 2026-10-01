using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
