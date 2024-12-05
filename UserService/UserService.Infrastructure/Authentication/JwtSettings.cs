using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Infrastructure.Authentication
{

    /* Used to access app settings related to Jwt */
    public class JwtSettings
    {
        public string Key {get; set;}

        public string Issuer {get; set;}
    }
}