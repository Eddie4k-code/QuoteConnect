using Microsoft.EntityFrameworkCore;
using UserService.Domain.Entities;

namespace UserService.Infrastructure.Persistence.Context;


public class UserDatabaseContext : DbContext
{

public DbSet<User> Users { get; set; }

 public UserDatabaseContext(DbContextOptions<UserDatabaseContext> options) : base(options)
{
}


}