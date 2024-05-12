using Microsoft.AspNetCore.Mvc;

namespace NH_WEBSITE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
