using Resume.Application;
using Resume.Infrastructure.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly ResumeDbContext _context;
    public UnitOfWork(ResumeDbContext dbContext)
    {
        _context = dbContext;
    }
    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public async Task SaveChangeAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }

}
