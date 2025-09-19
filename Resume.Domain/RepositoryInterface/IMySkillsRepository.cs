using Resume.Domain.Entities;

namespace Resume.Domain.RepositoryInterface;

public interface IMySkillsRepository
{
    List<MySkills> GetListOfSkills();
    MySkills? GetSkillByID(int id);
    void Add(MySkills mySkill);
    void Update(MySkills mySkill);
    void Delete(MySkills mySkill);
}
