using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Application.Interfaces;
using UserService.Application.Interfaces.Persistence;
using UserService.Domain.Entities;

namespace UserService.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;

        public UserService(IUserRepository userRepository, ILogger logger)
        {
            this._userRepository = userRepository;
            this._logger = logger;
        }

        public void Register(string username, string password)
        {
            try {

                //logic

            } catch(Exception err) {
                _logger.Log(err.Message);
            }
        }

        public User Login(string username, string password)
        {

            throw new NotImplementedException();
            
        }
    }
}