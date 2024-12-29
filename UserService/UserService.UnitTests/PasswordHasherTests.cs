using UserService.Infrastructure.Authentication;

public class PasswordHasherTests 
{
    public void HashPassword_ShouldReturnHashedPassword_IsString()
    {
        var passwordHasher = new BCryptPasswordHasher();

        var password = "test123";
        var hashedPassword = passwordHasher.HashPassword(password);

        Assert.IsType<string>(hashedPassword);
    }

    public void VerifyHashedPassword_ShouldReturnTrue_IsTrue()
    {
        var passwordHasher = new BCryptPasswordHasher();

        var password = "test123";
        var hashedPassword = passwordHasher.HashPassword(password);

        var result = passwordHasher.VerifyHashedPassword(hashedPassword, password);

        Assert.True(result);
    }
}