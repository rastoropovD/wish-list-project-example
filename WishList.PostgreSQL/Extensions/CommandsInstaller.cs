using Microsoft.Extensions.DependencyInjection;
using WishList.PostgreSQL.Commands.User.Create;

namespace WishList.PostgreSQL.Extensions;

public static class CommandsInstaller
{
    public static IServiceCollection AddUserCommands(this IServiceCollection services)
    {
        // add other user commands here
        services
            .AddScoped<ICreateUserCommand, CreateUserCommand>();
        
        return services;
    }
    
    public static IServiceCollection AddHolidayCommands(this IServiceCollection services)
    {
        // add holiday commands here
        
        return services;
    }
    
    public static IServiceCollection AddPresentCommands(this IServiceCollection services)
    {
        // add present commands here
        
        return services;
    }
}