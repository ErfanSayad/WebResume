using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;

namespace Resume.infrastructure.Repository
{
    public class EducationRepository : IEducationRepository
    {

        private readonly ResumeDbContext _context;
        public EducationRepository(ResumeDbContext context)
        {
            _context = context;
        }
        public List<Education> GetListOfEducations()
            => _context.Educations.ToList();

        public void Add(Education education)
            => _context.Educations.Add(education);

        public void Delete(Education education)
            => _context.Educations.Remove(education);

        public Education? GetEducationByID(int id)
            => _context.Educations.Find(id);


        public void Update(Education education)
            => _context.Educations.Update(education);
    }
}
