using Resume.Application.DTOs.AdminSide.Education;
using Resume.Domain.Entities;

namespace Resume.Application.Services.Interface;
public interface IEducationService
{
    List<ListOfEducationAdminSideDTO> GetListOfEducationsAdmin();
    List<Education> GetListOfEducations();
    Education? GetEducationByID(int id);
    void CreateEducation(Education education);
    void UpdateEducation(Education education);
    void DeleteEducation(Education education);

}
