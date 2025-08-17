using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;

namespace Resume.infrastructure.Repository
{
    public class EducationRepository : IEducationRepository
    {
        #region Ctor
        private readonly ResumeDbContext _context;
        public EducationRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<Education> GetListOfEducations()
        {
            return _context.Educations.ToList();
        }


    }
}
