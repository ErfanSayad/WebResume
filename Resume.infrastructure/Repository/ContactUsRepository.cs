using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;

namespace Resume.infrastructure.Repository;

public class ContactUsRepository : IContactUsRepository
{
    #region Ctor

    private readonly ResumeDbContext _context;
    public ContactUsRepository(ResumeDbContext context)
    {
        _context = context;
    }
    #endregion

    //public void CreatMessage(ContactUs contact)
    //{
    //    _context.ContactUs.Add(contact);
    //    _context.SaveChanges();
    //}

    public async Task CreatMessage(ContactUs contact)
    {
        await _context.ContactUs.AddAsync(contact);
        await _context.SaveChangesAsync();
    }
}
