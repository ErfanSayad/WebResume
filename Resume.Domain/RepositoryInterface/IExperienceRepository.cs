using Resume.Domain.Entities;

namespace Resume.Domain.RepositoryInterface;

public interface IExperienceRepository
{
    List<Experience> GetListOfExperience();
    public Experience? GetExperienceByID(int id);
    public void Add(Experience experience);
    public void Delete(Experience experience);
    public void Update(Experience experience);
}
