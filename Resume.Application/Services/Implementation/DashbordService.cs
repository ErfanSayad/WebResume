using Resume.Application.DTOs.SiteSide.Home_index;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation;

public class DashbordService : IDashbordService
{


    private readonly IEducationService _educationService;
    private readonly IExperienceService _experienceService;
    private readonly IMySkillService _mySkillService;

    public DashbordService(IEducationService educationService,
                           IExperienceService experienceService, 
                           IMySkillService mySkillService)
    {
        _educationService = educationService;
        _experienceService = experienceService;
        _mySkillService = mySkillService;
    }

    public async Task<HomeIndexModel> FillDashbordModel()
    {
        #region List of Skills
        var mySkills = _mySkillService.GetListOfSkills();

        #endregion

        #region List of Educations
        List<Education> educations = _educationService.GetListOfEducations();

        #endregion

        #region List of Experience
        List<Experience> experiences = _experienceService.GetListOfExperience();

        #endregion



        HomeIndexModel model = new HomeIndexModel();

        model.Experiences = experiences;
        model.Educations = educations;
        model.mySkills = mySkills;

        return model;
    }


}
