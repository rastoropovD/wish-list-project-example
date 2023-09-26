using WishList.PostgreSQL.Data.Repositories.Guest;
using WishList.PostgreSQL.Data.Repositories.Holiday;
using WishList.PostgreSQL.Data.Repositories.Present;
using WishList.PostgreSQL.Entities;
using WishList.PostgreSQL.Exceptions;

namespace WishList.PostgreSQL.Data.Repositories.Factory;

public sealed class RepositoryFactory : IRepositoryFactory
{
    public IRepository Instantiate<TEntity>(WishListDbContext context) where TEntity : class
    {
        return typeof(TEntity).Name switch
        {
            nameof(UserEntity) => new UserRepository(context),
            nameof(GuestEntity) => new GuestRepository(context),
            nameof(HolidayEntity) => new HolidayRepository(context),
            nameof(PresentEntity) => new PresentRepository(context),
            _ => throw new UnsupportedRepositoryTypeException(typeof(TEntity).Name)
        };
    }
}