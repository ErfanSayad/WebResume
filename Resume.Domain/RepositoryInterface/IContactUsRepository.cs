
using Resume.Domain.Entities.ContactUs;

namespace Resume.Domain.RepositoryInterface;

public interface IContactUsRepository
{
    // Creat Method
    Task CreatMessage(ContactUs contact);
    // Read Method

}
