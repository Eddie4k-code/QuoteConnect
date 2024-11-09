using UserService.Domain.Exceptions;

public class Username
{
    public string Value {get; private set;}

    public Username(string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length < 3)
        {
            throw new InvalidUsernameException();
        }

        Value = value;
    }
}