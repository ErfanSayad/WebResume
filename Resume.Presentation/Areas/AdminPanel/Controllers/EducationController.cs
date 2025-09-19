using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Implementation;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
namespace Resume.Presentation.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class EducationController : Controller
{
    #region Ctor
    private readonly IEducationService _educationService;
    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }
    #endregion

    #region List Of Education

    [HttpGet]
    public IActionResult ListOfEducations()
    {
        var model = _educationService.GetListOfEducations();
        return View(model);
    }
    #endregion

    #region Create an Education

    [HttpGet]
    public IActionResult CreateEducation()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult CreateEducation(Education education)
    {
        if (!ModelState.IsValid)
        {
            _educationService.CreateEducation(education);

            return RedirectToAction(nameof(ListOfEducations));
        }

        return View(education);
    }
    #endregion

    #region Edit an Education

    [HttpGet]
    public IActionResult EditeEducation(int EducationID)
    {
        var Edu = _educationService.GetEducationByID(EducationID);
        if (Edu == null)
            return NotFound();


        return View(Edu);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult EditeEducation(Education education)
    {
        _educationService.UpdateEducation(education);

        return RedirectToAction(nameof(ListOfEducations));
    }
    #endregion

    #region Delete an Education

    [HttpGet]
    public IActionResult DeleteEducation(int educationID)
    {
        var Edu = _educationService.GetEducationByID(educationID);
        if (Edu == null)
            return NotFound();

        return View(Edu);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult DeleteEducation(Education education)
    {
        _educationService.DeleteEducation(education);
        return RedirectToAction(nameof(ListOfEducations));
    }
    #endregion
}
