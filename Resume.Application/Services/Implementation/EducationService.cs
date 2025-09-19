using Resume.Application.DTOs.AdminSide.Education;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation;
public class EducationService : IEducationService
{

	readonly private IEducationRepository _educationRepository;
    private readonly IUnitOfWork _unitOfWork;

    public EducationService(IEducationRepository educationRepository, IUnitOfWork unitOfWork)
    {
         _educationRepository = educationRepository;
        _unitOfWork = unitOfWork;
    }

    public List<Education> GetListOfEducations()
    {
        return _educationRepository.GetListOfEducations();
    }

    public List<ListOfEducationAdminSideDTO> GetListOfEducationsAdmin()
    {
        List<Education> educations = _educationRepository.GetListOfEducations();

        #region Object Mapping

        List<ListOfEducationAdminSideDTO> returnModel = new List<ListOfEducationAdminSideDTO>();

        foreach (var edu in educations)
        {

            ListOfEducationAdminSideDTO childModel = new ListOfEducationAdminSideDTO();
            childModel.Id = edu.Id;
            childModel.EducationTitle = edu.EducationTitle;
            childModel.Duration = edu.EducationDuration;

            returnModel.Add(childModel);
        }
        #endregion

        return returnModel;
    }

    public List<Education> GetListOfEducation()
        => _educationRepository.GetListOfEducations();

    public Education? GetEducationByID(int id)
        => _educationRepository.GetEducationByID(id);

    public void CreateEducation(Education education)
    {
        _educationRepository.Add(education);
        _unitOfWork.SaveChanges();
    }

    public void DeleteEducation(Education education)
    {
        _educationRepository.Delete(education);
        _unitOfWork.SaveChanges();
    }

    public void UpdateEducation(Education education)
    {
        _educationRepository.Update(education);
        _unitOfWork.SaveChanges();
    }

}
