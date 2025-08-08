using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.Education;
using Resume.Presentation.Models.ResumeDbContext;
namespace Resume.Presentation.Controllers;



public class EducationController : Controller
{
    #region Ctor

    // 1) Make Instance:
    //ResumeDbContext _dbContext = new ResumeDbContext();

    // 2) Dependency Injection:
    private ResumeDbContext _context;

    public EducationController(ResumeDbContext context)
    {
        _context = context;
    }
    #endregion

    #region Get List of Education

    [HttpGet]
    public async Task<IActionResult> ListOfEducations()
    {
        //List of educations
        List<Education> educations = await _context.Educations.ToListAsync();

        return View();
    }
    #endregion

    #region Create an Education
    public async Task<IActionResult> CreateEducation()
    {
        Education education = new Education();
        education.EducationDuration = "2027";
        education.EducationTitle = "Test";
        education.Description = "Test Degree";

        await _context.Educations.AddAsync(education);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(ListOfEducations));
    }
    #endregion

    #region Delete Education
    public async Task<IActionResult> DeleteEducation()
    {
        var education = await _context.Educations.FirstOrDefaultAsync(p => p.Id == 4);

        _context.Educations.Remove(education);
        await _context.SaveChangesAsync();

        return View();
    }

    #endregion


}
