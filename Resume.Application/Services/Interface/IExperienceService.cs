using Resume.Domain.Entities;

namespace Resume.Application.Services.Interface;
public interface IExperienceService
{
    List<Experience> GetListOfExperience();
    Experience? GetExperienceByID(int id);
    void CreateExperience(Experience experience);
    void DeleteExperience(Experience experience);
    void UpdateExperience(Experience experience);
}
