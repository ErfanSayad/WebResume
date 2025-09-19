using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation;
public class ExperienceService : IExperienceService
{
	private readonly IExperienceRepository _experienceRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ExperienceService(IExperienceRepository experienceRepository, IUnitOfWork unitOfWork)
    {
        _experienceRepository = experienceRepository;
        _unitOfWork = unitOfWork;
    }


    public List<Experience> GetListOfExperience()
        => _experienceRepository.GetListOfExperience();

    public Experience? GetExperienceByID(int id)
        => _experienceRepository.GetExperienceByID(id);

    public void CreateExperience(Experience Experience)
    {
        _experienceRepository.Add(Experience);
        _unitOfWork.SaveChanges();
    }

    public void DeleteExperience(Experience Experience)
    {
        _experienceRepository.Delete(Experience);
        _unitOfWork.SaveChanges();
    }

    public void UpdateExperience(Experience Experience)
    {
        _experienceRepository.Update(Experience);
        _unitOfWork.SaveChanges();
    }

}
