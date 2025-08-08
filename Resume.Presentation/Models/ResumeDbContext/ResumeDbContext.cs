using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.Education;
using Resume.Presentation.Models.Entities.Experience;
using Resume.Presentation.Models.Entities.MySkills;
namespace Resume.Presentation.Models.ResumeDbContext;

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
