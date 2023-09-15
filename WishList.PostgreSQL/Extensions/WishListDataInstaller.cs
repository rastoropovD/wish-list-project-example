using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WishList.PostgreSQL.Data;

namespace WishList.PostgreSQL.Extensions;

public static class WishListDataInstaller
{
    public static IServiceCollection AddWishListData(this IServiceCollection services, string connectionString)
    {
        services.AddDbContextPool<WishListDbContext>(options => 
            options
                .UseNpgsql(connectionString, builder => builder.MigrationsAssembly("WishList.PostgreSQL"))
            );
        
        return services;
    }
}