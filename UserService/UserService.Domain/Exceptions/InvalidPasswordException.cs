namespace UserService.Domain.Exceptions;


public class InvalidPasswordException : Exception
{
    public InvalidPasswordException() : base("Please make a stronger password.")
    {

    }
}