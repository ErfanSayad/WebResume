using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;

namespace Resume.infrastructure.Repository;

public class MySkillsRepository : IMySkillsRepository
{

    private readonly ResumeDbContext _context;
    public MySkillsRepository(ResumeDbContext context)
    {
        _context = context;
    }

    public List<MySkills> GetListOfSkills()
        => _context.mySkills.ToList();

    public MySkills? GetSkillByID(int id)
        => _context.mySkills.Find(id);

    public void Add(MySkills mySkill)
        => _context.mySkills.Add(mySkill);

    public void Delete(MySkills mySkill)
        => _context.mySkills.Remove(mySkill);

    public void Update(MySkills mySkill)
        => _context.mySkills.Update(mySkill);
}
