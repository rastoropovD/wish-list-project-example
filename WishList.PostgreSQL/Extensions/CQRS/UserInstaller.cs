using Microsoft.Extensions.DependencyInjection;
using WishList.PostgreSQL.CQRS.Core.Command;
using WishList.PostgreSQL.CQRS.Core.Query;
using WishList.PostgreSQL.CQRS.User.Commands.Create;
using WishList.PostgreSQL.CQRS.User.Queries.FindUser;
using WishList.PostgreSQL.Dtos.User;

namespace WishList.PostgreSQL.Extensions.CQRS;

public static class UserInstaller
{
    public static IServiceCollection AddUserCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICommandHandler<CreateUserCommand>, CreateUserCommandHandler>();
        
        return services;
    }
    
    public static IServiceCollection AddUserQueries(this IServiceCollection services)
    {
        services
            .AddScoped<IQueryHandler<FindUserQuery, UserInfoDto?>, FindUserQueryHandler>();
        
        return services;
    }
}