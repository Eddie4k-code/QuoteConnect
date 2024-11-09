namespace UserService.Domain.Exceptions;


public class InvalidUsernameException : Exception
{
    public InvalidUsernameException() : base("Username is not valid, please try again")
    {

    }
}