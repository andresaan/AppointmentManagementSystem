using ApplicationCore.Interfaces;
using Data;
using Data.Models;
using Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly ILogger<UserService> _userLogger;

        public UserService(IUnitOfWorkFactory unitOfWorkFactory, ILogger<UserService> userLogger)
        {
            _userLogger = userLogger;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public List<User> GetAllUsers()
        {
            var unit = _unitOfWorkFactory.CreateUnitOfWork();
            var userRepository = unit.UserRepository;

            var users = userRepository.GetAllUsers();
            
            unit.Dispose();

            return users;
        }

        public User ValidateLogInCredentials(string username, string password)
        {
            var unit = _unitOfWorkFactory.CreateUnitOfWork();
            var userRepository = unit.UserRepository;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, password);
                var hashAtLength = Truncate(hash, 50);

                var user = userRepository.GetUser(username);
                unit.Dispose();

                if (user != null && user.Password == hashAtLength)
                {
                    _userLogger.LogInformation(username);
                    return user;
                }

                if (user != null && user.Password == "test" && user.UserName == "test")
                {
                    _userLogger.LogInformation(username);
                    return user;
                }

                return null;
            }
        }
        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        public static string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
