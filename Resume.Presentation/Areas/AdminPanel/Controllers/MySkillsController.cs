using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
namespace Resume.Presentation.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class MySkillsController : Controller
{
    #region Ctor
    private readonly IMySkillService _mySkillService;
    public MySkillsController(IMySkillService mySkillService)
    {
        _mySkillService = mySkillService;
    }
    #endregion

    #region List Of Skills

    [HttpGet]
    public IActionResult ListOfMySkills()
    {
        ViewData["Title"] = "لیست مهارت ها";
        var model = _mySkillService.GetListOfSkills();
        return View(model);
    }
    #endregion

    #region Create an Skills

    [HttpGet]
    public IActionResult CreateMySkill()
    {
        ViewData["Title"] = "افزودن مهارت";
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult CreateMySkill(MySkills mySkills)
    {
        if (!ModelState.IsValid)
        {
            _mySkillService.CreateMySkill(mySkills);

            return RedirectToAction(nameof(ListOfMySkills));
        }

        return View(mySkills);
    }
    #endregion

    #region Edit an Skills

    [HttpGet]
    public IActionResult EditeMySkill(int mySkillsID)
    {
        var mySkill = _mySkillService.GetSkillByID(mySkillsID);
        if (mySkill == null)
            return NotFound();


        return View(mySkill);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult EditeMySkill(MySkills skills)
    {
        _mySkillService.UpdateMySkill(skills);

        return RedirectToAction(nameof(ListOfMySkills));
    }
    #endregion

    #region Delete an Skills


    [HttpGet]
    public IActionResult DeleteMySkill(int mySkillsID)
    {
        var skill = _mySkillService.GetSkillByID(mySkillsID);
        if (skill == null)
            return NotFound();

        return View(skill);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult DeleteMySkill(MySkills MySkill)
    {
        _mySkillService.DeleteMySkill(MySkill);
        return RedirectToAction(nameof(ListOfMySkills));
    }
    #endregion
}
