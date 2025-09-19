using Resume.Domain.Entities;

namespace Resume.Application.Services.Interface;

public interface IMySkillService
{
    List<MySkills> GetListOfSkills();
    public MySkills? GetSkillByID(int id);
    void CreateMySkill(MySkills mySkills);
    void DeleteMySkill(MySkills mySkills);
    void UpdateMySkill(MySkills mySkills);


}
