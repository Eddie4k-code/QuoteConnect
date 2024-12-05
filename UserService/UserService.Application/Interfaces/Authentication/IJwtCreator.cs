using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain.Entities;

namespace UserService.Application.Interfaces.Authentication
{
    public interface IJwtCreator
    {
        string CreateJwt(User user);
    }
}