using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers;

public class ContactUsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
