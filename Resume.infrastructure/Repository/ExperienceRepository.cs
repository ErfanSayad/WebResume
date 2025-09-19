using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;

namespace Resume.infrastructure.Repository;

public class ExperienceRepository : IExperienceRepository
{
    private readonly ResumeDbContext _context;
    public ExperienceRepository(ResumeDbContext context)
    {
        _context = context;
    }

    public List<Experience> GetListOfExperience()
        => _context.Experiences.ToList();


    public Experience? GetExperienceByID(int id)
        => _context.Experiences.Find(id);

    public void Add(Experience experience)
        => _context.Experiences.Add(experience);

    public void Delete(Experience experience)
        => _context.Experiences.Remove(experience);

    public void Update(Experience experience)
        => _context.Experiences.Update(experience);
}
