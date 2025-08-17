using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Application.DTOs.SiteSide.Home_index;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;
using Resume.Presentation.Models;
using System.Diagnostics;

namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEducationRepository _educationRepository;
        private readonly IExperienceRepository _experienceRepository;
        private readonly IMySkills _mySkills;

        public HomeController(IEducationRepository educationRepository, IExperienceRepository experienceRepository, IMySkills mySkills)
        {
            _educationRepository = educationRepository;
            _experienceRepository = experienceRepository;
            _mySkills = mySkills;
        }



        public IActionResult Index()
        {
            var mySkills = _mySkills.GetListOfSkills();

            List<Education> educations = _educationRepository.GetListOfEducations();

            List<Experience> experiences = _experienceRepository.GetListOfExperience();

            #region ViewBag()  ,  ViewData[]  ,  TempData[]
            //ViewBag.Education = educations;
            //ViewBag.Experience = experiences;
            //ViewBag.mySkills = mySkillsAsync;
            #endregion

            #region Fill Instance Model
            HomeIndexModel models = new HomeIndexModel()
            {
                Experiences = experiences,
                Educations = educations,
                mySkills = mySkills
            };

            #endregion
            return View(models);
        }

    }
}
