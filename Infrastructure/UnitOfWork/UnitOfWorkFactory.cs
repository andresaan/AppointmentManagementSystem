using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public ClientScheduleDbContext CreateContext()
        {
            return new ClientScheduleDbContext();
        }

        public UnitOfWork CreateUnitOfWork()
        {

            return new UnitOfWork(CreateContext());

        }
    }
}
