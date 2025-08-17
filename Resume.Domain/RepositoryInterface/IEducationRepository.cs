using Resume.Domain.Entities;

namespace Resume.Domain.RepositoryInterface;

public interface IEducationRepository
{
    //GetListOfEducations
    List<Education> GetListOfEducations();
}
