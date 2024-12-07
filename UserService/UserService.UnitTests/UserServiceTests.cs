using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Microsoft.Extensions.Options;
using Moq;
using UserService.Application.Interfaces.Persistence;
using UserService.Application.Results;
using UserService.Application.Services;
using UserService.Domain.Entities;
using UserService.Domain.ValueObjects;
using UserService.Infrastructure.Authentication;
namespace UserService.UnitTests
{
    public class UserServiceTests
    {
        private readonly IAuthenticationService _userService;
        private readonly Mock<IUserRepository> _userRepositoryMock = new Mock<IUserRepository>();
        

        public UserServiceTests() {
            var jwtSettings = Options.Create(new JwtSettings());
            jwtSettings.Value.Key = "hweofhiowgerhioegwriohgewrhoieg8h329";
            jwtSettings.Value.Issuer = "issuer";
            this._userService = new AuthenticationService(_userRepositoryMock.Object, new JwtCreator(jwtSettings));
        }

        [Fact]
        public void Login_ShouldReturnUser_IfUserExistsAndCorrectPassword()
        {
            
            var user = new User{
                Username = new Username("Test1234567"),
                Password = new Password("Test1234567")
            };


            this._userRepositoryMock.Setup(x => x.GetUser(user.Username.Value)).Returns(user);

            var loggedInUser = this._userService.Login(user.Username.Value, user.Password.Value);

            Assert.Equal(loggedInUser.UserId.Value, user.Id.Value);




        }
    }
}