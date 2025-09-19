using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
namespace Resume.Presentation.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class ExperienceController : Controller
{
    private readonly IExperienceService _experienceService;
    public ExperienceController(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    #region List Of Experience

    [HttpGet]
    public IActionResult ListOfExperience()
    {
        var model = _experienceService.GetListOfExperience();
        return View(model);
    }
    #endregion

    #region Create an Experience

    [HttpGet]
    public IActionResult CreateExperience()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult CreateExperience(Experience experience)
    {
        if (!ModelState.IsValid)
        {
            _experienceService.CreateExperience(experience);

            return RedirectToAction(nameof(ListOfExperience));
        }

        return View(experience);
    }
    #endregion

    #region Edit an Experience

    [HttpGet]
    public IActionResult EditeExperience(int ExperienceID)
    {
        var experience = _experienceService.GetExperienceByID(ExperienceID);
        if (experience == null)
            return NotFound();


        return View(experience);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult EditeExperience(Experience experience)
    {
        _experienceService.UpdateExperience(experience);

        return RedirectToAction(nameof(ListOfExperience));
    }
    #endregion

    #region Delete an Experience


    [HttpGet]
    public IActionResult DeleteExperience(int ExperienceID)
    {
        var experience = _experienceService.GetExperienceByID(ExperienceID);
        if (experience == null)
            return NotFound();

        return View(experience);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult DeleteExperience(Experience experience)
    {
        _experienceService.DeleteExperience(experience);
        return RedirectToAction(nameof(ListOfExperience));
    }
    #endregion
}
