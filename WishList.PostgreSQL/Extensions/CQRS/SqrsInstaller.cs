using Microsoft.Extensions.DependencyInjection;

namespace WishList.PostgreSQL.Extensions.CQRS;

public static class SqrsInstaller
{
    public static IServiceCollection AddSQRS(this IServiceCollection services)
    {
        services
            .AddUserCommands()
            .AddUserQueries();
        
        return services;
    }
}