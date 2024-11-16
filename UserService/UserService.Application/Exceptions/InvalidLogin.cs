using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Application.Exceptions
{   

    public class InvalidLogin  : Exception
    {

        public InvalidLogin()  : base("Incorrect Username or Password") {

        }
        
    }
}