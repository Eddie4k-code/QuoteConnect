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
using UserService.Infrastructure.Persistence;
using UserService.Application.Interfaces.Persistence;
using UserService.Application.Interfaces.Authentication;

namespace UserService.Infrastructure
{
    public static class AddInfrastructureServices 
    {

        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfiguration config) 
        {
            var JwtSettings = new JwtSettings();
            
            config.Bind("Jwt", JwtSettings);

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJwtCreator, JwtCreator>();
            services.AddScoped<IPasswordHasher, BCryptPasswordHasher>();


            services.AddDbContext<UserDatabaseContext>(options => 
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }        
    }
}