namespace UserService.UnitTests;

using UserService;
using UserService.Domain.Entities;

public class UserTests
{
    [Fact]
    public void Test1()
    {

        var user = new User{
            Username = "John Doe",
            Password = "123"
        };

    }
}