using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Moq;
using UserService.Application.Interfaces.Persistence;
using UserService.Application.Results;
using UserService.Application.Services;
using UserService.Domain.Entities;
using UserService.Domain.ValueObjects;
namespace UserService.UnitTests
{
    public class UserServiceTests
    {
        private readonly IAuthenticationService _userService;
        private readonly Mock<IUserRepository> _userRepositoryMock = new Mock<IUserRepository>();

        public UserServiceTests() {
            this._userService = new AuthenticationService(_userRepositoryMock.Object);
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