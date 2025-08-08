using Resume.Presentation.Models.Entities.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Resume.Application.Services.Interface;

public interface IEducationService
{
    //List<Education> GetEducations(); => sync methods.
    Task<List<Education>> GetAllEducations(); // async method


    //void CreateEducation(Education education); => sync methods.
    Task CreateEducation(Education education); // async method

    Task DeleteEducation(int id); // async method to delete education by id
    Task UpdateEducation(Education education);

}
