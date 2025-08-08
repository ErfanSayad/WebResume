using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.Education;
using Resume.Presentation.Models.ResumeDbContext;
using Resume.Application;

namespace Resume.Presentation.Controllers;

public class EducationController : Controller
{

    public EducationController() { }

    private readonly IEducationservies;

    #region Get List of Education

    [HttpGet]
    public async Task<IActionResult> ListOfEducations()
    {
        return View();
    }
    #endregion

    #region Create an Education
    public async Task<IActionResult> CreateEducation()
    {
        return View();
    }
    #endregion

    #region Delete Education
    public async Task<IActionResult> DeleteEducation()
    {
        return View();
    }
    #endregion

    #region Update Education
    public async Task<IActionResult> UpdateEducation()
    {
        return View();
    }
    #endregion
}
