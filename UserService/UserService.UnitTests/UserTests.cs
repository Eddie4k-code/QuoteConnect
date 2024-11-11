namespace UserService.UnitTests;

using UserService;
using UserService.Domain.Entities;
using UserService.Domain.Exceptions;

public class UserTests
{
    [Fact]
    public void Follow_FollowUser_ShouldFollow()
    {

        var user = new User{
            Username = new Username("John Doe"),
            Password = new Password("password_Test123")
        };

        var userToFollow = new User{
            Username = new Username("John Smith"),
            Password = new Password("password_Test123")
        };

        
        user.Follow(userToFollow.Id);


        Assert.Contains(userToFollow.Id, user.GetFollowers());

    }


    [Fact]
    public void Password_EmptyPassword_ThrowError()
    {
       Assert.Throws<InvalidPasswordException>(() => new User{
        Username = new Username("John Doe"),
        Password = new Password("")
       });
    }
}