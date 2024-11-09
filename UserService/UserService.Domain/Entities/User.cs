using UserService.Domain.ValueObjects;

namespace UserService.Domain.Entities;

public class User
{
    public UserId Id {get; set;} = new UserId(Guid.NewGuid());
    public Username Username {get; set;}

    
    private readonly HashSet<UserId> _followers = new HashSet<UserId>();

    public Password Password {get; set;}


    /* Follow another user */
    public void Follow(UserId followerId)
    {
        if (!this._followers.Contains(followerId))
        {
            this._followers.Add(followerId);
        }
    }

    /* Unfollow a user */
    public void Unfollow(UserId followerId)
    {
        if (this._followers.Contains(followerId))
        {
            this._followers.Remove(followerId);
        }
    }
    


}