using Data.Models;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private ClientScheduleDbContext _context;
        private ICustomerRepository _customerRepository;
        private IAppointmentRepository _appointmentRepository;
        private IUserRepository _userRepository;
        private bool disposed = false;


        public UnitOfWork(ClientScheduleDbContext dbContext)
        {
            _context = dbContext;
        }


        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);
                }

                return _userRepository;
            }
        }
        public IAppointmentRepository AppointmentRepository
        {
            get
            {
                if (_customerRepository == null) 
                {
                    _appointmentRepository = new AppointmentRepository(_context);
                }

                return _appointmentRepository;
            }
        }
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (this._customerRepository == null)
                {
                    this._customerRepository = new CustomerRepository(_context);
                }
                return _customerRepository;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
