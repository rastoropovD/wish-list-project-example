using Microsoft.Extensions.DependencyInjection;
using WishList.PostgreSQL.CQRS.User.Commands.Create;
using WishList.PostgreSQL.CQRS.User.Queries.FindUser;

namespace WishList.PostgreSQL.Extensions.CQRS;

public static class UserInstaller
{
    public static IServiceCollection AddUserCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateUserCommandHandler, CreateUserCommandHandler>();
        
        return services;
    }
    
    public static IServiceCollection AddUserQueries(this IServiceCollection services)
    {
        services
            .AddScoped<IFindUserQueryHandler, FindUserQueryHandler>();
        
        return services;
    }
}