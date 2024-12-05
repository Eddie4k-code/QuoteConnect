using Microsoft.Extensions.Options;
using UserService.Domain.Entities;
using UserService.Infrastructure.Authentication;

public class JwtCreatorTests
{
    [Fact]
    public void CreateJwt_ShouldReturnJwt_IsString()
    {
        var jwtSettings = Options.Create(new JwtSettings());
        jwtSettings.Value.Key = "iegonrigreonigoer3490r329403grhio3nroi";
        jwtSettings.Value.Issuer = "issuer";

        var jwtCreator = new JwtCreator(jwtSettings);


        var user = new User{
            Username = new Username("test123"),
            Password = new Password("test123")
        };

        var token = jwtCreator.CreateJwt(user);

        Assert.IsType<string>(token);
    }
}