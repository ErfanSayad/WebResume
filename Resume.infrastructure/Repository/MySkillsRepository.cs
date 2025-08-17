using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;

namespace Resume.infrastructure.Repository;

public class MySkillsRepository : IMySkills
{
    #region Ctor
    private readonly ResumeDbContext _context;
    public MySkillsRepository(ResumeDbContext context)
    {
        _context = context;
    }

    #endregion
    public List<MySkills> GetListOfSkills()
    {
        return _context.mySkills.ToList();
    }

}
