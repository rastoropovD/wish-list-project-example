using Microsoft.Extensions.DependencyInjection;
using WishList.PostgreSQL.MediatorImpl;

namespace WishList.PostgreSQL.Extensions.CQRS;

public static class CqrsInstaller
{
    public static IServiceCollection AddCQRS(this IServiceCollection services)
    {
        services
            .AddUserCommands()
            .AddUserQueries()
            .AddScoped<IMediator, Mediator>();
        
        return services;
    }
}