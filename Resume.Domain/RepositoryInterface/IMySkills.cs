using Resume.Domain.Entities;

namespace Resume.Domain.RepositoryInterface;

public interface IMySkills
{
    //GetListOfSkills
    List<MySkills> GetListOfSkills();
}
