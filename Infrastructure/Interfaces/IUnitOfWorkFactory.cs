using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.UnitOfWork;

namespace Infrastructure.Interfaces
{
    public interface IUnitOfWorkFactory
    {
        UnitOfWork.UnitOfWork CreateUnitOfWork();
    }
}
