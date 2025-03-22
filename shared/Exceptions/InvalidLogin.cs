namespace shared.CustomExceptions;
public class InvalidLogin : CustomException 
{
    public override int StatusCode => 401; // Unauthorized

    public InvalidLogin() : base("Incorrect Username or Password") 
    {
        
    }
}