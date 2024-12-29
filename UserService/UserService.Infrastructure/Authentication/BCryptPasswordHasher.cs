using UserService.Application.Interfaces.Authentication;
using BC = BCrypt.Net.BCrypt;
namespace UserService.Infrastructure.Authentication;

public class BCryptPasswordHasher : IPasswordHasher
{
    public string HashPassword(string password)
    {
        return BC.HashPassword(password);
    }

    public bool VerifyHashedPassword(string hashedPassword, string password)
    {
        return BC.Verify(password, hashedPassword);
    }
}