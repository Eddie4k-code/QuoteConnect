using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain.Entities;

namespace UserService.Application.Interfaces.Persistence
{
    public interface IUserService
    {

        void Register(string username, string password);

        User Login(string username, string password);
    }
}