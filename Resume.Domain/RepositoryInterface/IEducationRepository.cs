using Resume.Domain.Entities;

namespace Resume.Domain.RepositoryInterface;

public interface IEducationRepository
{
    List<Education> GetListOfEducations();
    Education? GetEducationByID(int id);
    void Add(Education education);
    void Update(Education education);
    void Delete(Education education);
}
