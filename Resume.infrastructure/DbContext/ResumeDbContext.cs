using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities;
namespace Resume.Infrastructure.ResumeDbContext;

public class ResumeDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=ERFANPC;Initial Catalog=MyResume;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<MySkills> mySkills { get; set; }
}
