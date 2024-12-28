using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Application.Results;
using UserService.Domain.Entities;

namespace UserService.Application.Interfaces.Persistence
{
    public interface IAuthenticationService
    {

        Task<UserResult> Register(string username, string password);

        Task<UserResult> Login(string username, string password);
    }
}