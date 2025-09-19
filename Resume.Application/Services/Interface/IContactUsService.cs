
using Resume.Domain.Entities.ContactUs;

namespace Resume.Application.Services.Interface;

public interface IContactUsService
{
    Task AddNewContactUs(ContactUs contact);
}
