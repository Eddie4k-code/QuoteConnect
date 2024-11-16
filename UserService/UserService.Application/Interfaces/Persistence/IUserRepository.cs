using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain.Entities;

namespace UserService.Application.Interfaces.Persistence
{   

    /* All concrete implementations for a user repository will implement this interface */
    public interface IUserRepository
    {

        void CreateUser(string email, string password);

        User GetUser(string email);

    }
}