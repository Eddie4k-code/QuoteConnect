using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Application.Exceptions;
using UserService.Application.Interfaces;
using UserService.Application.Interfaces.Authentication;
using UserService.Application.Interfaces.Persistence;
using UserService.Application.Results;
using UserService.Domain.Entities;

namespace UserService.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IUserRepository _userRepository;
        private readonly IJwtCreator _jwtCreator;
        
        public AuthenticationService(IUserRepository userRepository, IJwtCreator jwtCreator)
        {
            this._userRepository = userRepository;
            this._jwtCreator = jwtCreator;
        }

        public UserResult Register(string username, string password)
        {

            var user = this._userRepository.CreateUser(username, password);

            return new UserResult(user.Id, user.Username, this._jwtCreator.CreateJwt(user));

        }

        public UserResult Login(string username, string password)
        {

            var user = this._userRepository.GetUser(username) ?? throw new InvalidLogin();

            if (user.Password.Value == password) {
                return new UserResult(user.Id, user.Username, this._jwtCreator.CreateJwt(user));
            }

            throw new InvalidLogin();
                        
        }
    }
}