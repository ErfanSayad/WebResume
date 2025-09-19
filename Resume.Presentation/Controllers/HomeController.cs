using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Application.DTOs.SiteSide.Home_index;
using Resume.Application.Services.Implementation;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDashbordService _dashbordService;
        public HomeController(IDashbordService dashbordService)
        {
            _dashbordService = dashbordService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _dashbordService.FillDashbordModel();

            return View(model);
        }

        public IActionResult IndexPartial()
        {
            return PartialView("_IndexPartial");
        }


    }
}
