namespace UserService.Infrastructure.Persistence;

using System.Threading.Tasks;
using UserService.Application.Interfaces.Persistence;
using UserService.Infrastructure.Persistence.Context;
using UserService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
public class UserRepository : IUserRepository
{

    private readonly UserDatabaseContext _context;

    public UserRepository(UserDatabaseContext context)
    {
        _context = context;
    }


    public async Task<User> CreateUser(string username, string password)
    {
        var user = await _context.Users.AddAsync(new User{Username = new Username(username), Password = new Password(password)});

        await _context.SaveChangesAsync();

        return user.Entity;
    }

    public async Task<User> GetUser(string username)
    {

        var user = await _context.Users.FirstOrDefaultAsync(u => u.Username.Value == username);

        return user;

    }



}