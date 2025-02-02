namespace UserService.Application;


using Microsoft.Extensions.DependencyInjection;
using UserService.Application.Interfaces.Persistence;
using UserService.Application.Services;

public static class AddApplicationServices {
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services) {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}