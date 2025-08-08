using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interface;
using Resume.Presentation.Models.Entities.Education;
using Resume.Presentation.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Resume.Application.Services.Implementation;

public class EducationService : IEducationService
{
    #region Ctor

    private ResumeDbContext _context;

    public EducationService(ResumeDbContext context)
    {
        _context = context;
    }
    #endregion

    public async Task<List<Education>> GetAllEducations()
    {
        List<Education> educations = await _context.Educations.ToListAsync();
        return educations;
    }
    public Education GetAnEducationById(int Educationid)
    {
        var education = _context.Educations.FirstOrDefault(p => p.Id == Educationid);
        return education;
    }
    public async Task CreateEducation(Education education)
    {
        education.EducationTitle = "Test";
        education.EducationDuration = "2027";
        education.Description = "Test Degree";

        await _context.Educations.AddAsync(education);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteEducation(int id)
    {
        Education education = GetAnEducationById(id);
        if (education != null)
        {
            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();
        }
    }
    public async Task UpdateEducation(Education education)
    {
        _context.Educations.Update(education);
        await _context.SaveChangesAsync();
    }
}
