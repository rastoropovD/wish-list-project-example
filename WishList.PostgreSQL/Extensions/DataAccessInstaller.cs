using Microsoft.Extensions.DependencyInjection;
using WishList.PostgreSQL.Data.Repositories;
using WishList.PostgreSQL.Data.Repositories.Factory;
using WishList.PostgreSQL.Data.Repositories.Guest;
using WishList.PostgreSQL.Data.Repositories.Holiday;
using WishList.PostgreSQL.Data.Repositories.Present;
using WishList.PostgreSQL.Data.UnitOfWork;

namespace WishList.PostgreSQL.Extensions;

public static class DataAccessInstaller
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services)
    {
        services
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IGuestRepository, GuestRepository>()
            .AddScoped<IHolidayRepository, HolidayRepository>()
            .AddScoped<IPresentRepository, PresentRepository>();
        
        services
            .AddSingleton<IRepositoryFactory, RepositoryFactory>()
            .AddScoped<IUnitOfWork, UnitOfWork>();
            
        return services;
    }
}