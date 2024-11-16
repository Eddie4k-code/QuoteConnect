using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain.ValueObjects;

namespace UserService.Application.Results
{
     public record UserResult
    {
        public UserId UserId { get; init; }
        public Username Username { get; init; }
        public string Token { get; init; }


        public UserResult(UserId userId, Username username, string token) {
            this.UserId = userId;
            this.Token = token;
        } 

    }
}