using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserService.Infrastructure.Authentication;

namespace UserService.Infrastructure
{
    public static class AddInfrastructureServices 
    {

        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfiguration config) 
        {
            var JwtSettings = new JwtSettings();
            
            config.Bind("Jwt", JwtSettings);

            return services;
        }        
    }
}