using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;

namespace Resume.infrastructure.Repository
{
    public class ExperienceRepository : IExperienceRepository
    {
        #region Ctor
        private readonly ResumeDbContext _context;
        public ExperienceRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<Experience> GetListOfExperience()
        {
            return _context.Experiences.ToList();
        }

    }
}
