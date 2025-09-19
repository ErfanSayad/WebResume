
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation;

public class ContactUsService : IContactUsService
{
    #region Ctor

    private readonly IContactUsRepository _contactUsRepository;
    public ContactUsService(IContactUsRepository contactUsRepository)
    {
        _contactUsRepository = contactUsRepository;
    }

    #endregion
    public async Task AddNewContactUs(ContactUs contactUsDTO)
    {
        ContactUs contact = new ContactUs()
        {
            FullName = contactUsDTO.FullName,
            PhoneNumber = contactUsDTO.PhoneNumber,
            Message = contactUsDTO.Message
        };


        //Add to Database
        await _contactUsRepository.CreatMessage(contact);

    }

}
