using UserService.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

[Owned]
public class Password
{
    public string Value {get; private set;}

    public Password(string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length < 3)
        {
            throw new InvalidPasswordException();
        }

        Value = value;
    }
}