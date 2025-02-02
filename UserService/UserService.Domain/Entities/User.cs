using UserService.Domain.ValueObjects;

namespace UserService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public Guid Id {get; set;} = Guid.NewGuid();
    public Username Username {get; set;}

    
    public readonly HashSet<UserId> _followers  = new HashSet<UserId>();

    public Password Password {get; set;}


    /* Follow another user */
    public void Follow(Guid followerId)
    {
        if (!this._followers.Contains(followerId))
        {
            this._followers.Add(followerId);
        }
    }

    /* Unfollow a user */
    public void Unfollow(Guid followerId)
    {
        if (this._followers.Contains(followerId))
        {
            this._followers.Remove(followerId);
        }
    }

    public HashSet<Guid> GetFollowers()
    {
        return this._followers;
    }

}