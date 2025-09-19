using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
