using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserService.Infrastructure.Authentication;
using Microsoft.EntityFrameworkCore;
using UserService.Infrastructure.Persistence.Context;

namespace UserService.Infrastructure
{
    public static class AddInfrastructureServices 
    {

        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfiguration config) 
        {
            var JwtSettings = new JwtSettings();
            
            config.Bind("Jwt", JwtSettings);


            services.AddDbContext<UserDatabaseContext>(options => 
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }        
    }
}