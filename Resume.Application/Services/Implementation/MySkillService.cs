using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation;

public class MySkillService : IMySkillService
{

    private readonly IMySkillsRepository _skillsRepository;
    private readonly IUnitOfWork _unitOfWork;

    public MySkillService(IMySkillsRepository skillsRepository, IUnitOfWork unitOfWork)
    {
        _skillsRepository = skillsRepository;
        _unitOfWork = unitOfWork;
    }

    public List<MySkills> GetListOfSkills()
        => _skillsRepository.GetListOfSkills();

    public MySkills? GetSkillByID(int id)
        => _skillsRepository.GetSkillByID(id);

    public void CreateMySkill(MySkills mySkills)
    {
        _skillsRepository.Add(mySkills);
        _unitOfWork.SaveChanges();
    }

    public void DeleteMySkill(MySkills mySkills)
    {
        _skillsRepository.Delete(mySkills);
        _unitOfWork.SaveChanges();
    }

    public void UpdateMySkill(MySkills mySkills)
    {
        _skillsRepository.Update(mySkills);
        _unitOfWork.SaveChanges();
    }

}
