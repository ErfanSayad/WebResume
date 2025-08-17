using Resume.Domain.Entities;

namespace Resume.Domain.RepositoryInterface;

public interface IExperienceRepository
{
    //GetListOfExperience
    List<Experience> GetListOfExperience();
}
