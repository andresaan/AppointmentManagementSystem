using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User ValidateLogInCredentials(string username, string password);
    }
}
