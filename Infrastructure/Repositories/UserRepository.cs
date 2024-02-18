using Data.Models;
using Infrastructure.Interfaces;
using Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ClientScheduleDbContext _dbContext;
        public UserRepository(ClientScheduleDbContext clientScheduleDbContext)
        {
            _dbContext = clientScheduleDbContext;
        }
        public List<User> GetAllUsers()
        {
            return _dbContext.User.ToList();
        }

        public User GetUser(string username)
        {
            var user = _dbContext.User
                .Where(o => o.UserName == username)
                .FirstOrDefault();

            return user ?? null;
        }
    }
}
