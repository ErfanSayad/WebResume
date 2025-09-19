using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Presentation.Controllers;

public class ContactUsController : Controller
{
    private readonly IContactUsService _contactUsService;
    public ContactUsController(IContactUsService contactUsService)
    {
        _contactUsService = contactUsService;
    }




    [HttpGet]
    public IActionResult ContactUs()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> ContactUs(ContactUs contact)
    {
        await _contactUsService.AddNewContactUs(contact);
        return View();

    }
}
