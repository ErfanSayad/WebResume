using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application;

public interface IUnitOfWork
{
    Task SaveChangeAsync(CancellationToken cancellationToken);

    void SaveChanges();


}
