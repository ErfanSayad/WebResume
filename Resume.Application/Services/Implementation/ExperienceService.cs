using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation;
public class ExperienceService : IExperienceService
{
	#region Ctor
	private readonly IExperienceRepository _experienceRepository;

    public ExperienceService(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }
    #endregion
    public List<Experience> GetListOfExperience()
    {
        return _experienceRepository.GetListOfExperience();
    }
}
