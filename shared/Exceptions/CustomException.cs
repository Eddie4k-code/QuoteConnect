namespace shared.CustomExceptions;

public abstract class CustomException : Exception
{

    abstract public int StatusCode { get; }
    public CustomException(string message) : base(message)
    {

    }

    
}