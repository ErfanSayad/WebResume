namespace Resume.Domain.Entities;

public class Experience
{
    public int Id { get; set; }
    public string ExperienceTitle { get; set; }
    public string ExperienceDuration { get; set; }
    public string Description { get; set; }
    public string? companyName { get; set; }
    public string? companySite { get; set; }
}
