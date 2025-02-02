using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using UserService.Application.Interfaces.Authentication;
using UserService.Domain.Entities;

namespace UserService.Infrastructure.Authentication
{
    public class JwtCreator : IJwtCreator
    {

        private readonly JwtSettings _jwtSettings;

        public JwtCreator(IOptions<JwtSettings> jwtSettings) {

            this._jwtSettings = jwtSettings.Value;
            
        }

        public string CreateJwt(User user)
        {
            var claims = new []{
                new Claim(JwtRegisteredClaimNames.Sub, user.Username.Value),
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString())
            };

             var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._jwtSettings.Key));
             var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

              var token = new JwtSecurityToken(
            issuer: this._jwtSettings.Issuer,
            claims: claims,
            expires: DateTime.Now.AddMinutes(600),
            signingCredentials: creds);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

      
    }
    }
