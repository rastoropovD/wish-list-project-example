using WishList.PostgreSQL.Data.Repositories.Guest;
using WishList.PostgreSQL.Data.Repositories.Holiday;
using WishList.PostgreSQL.Data.Repositories.Present;
using WishList.PostgreSQL.Entities;
using WishList.PostgreSQL.Exceptions;

namespace WishList.PostgreSQL.Data.Repositories.Factory;

public sealed class RepositoryFactory : IRepositoryFactory
{
    // private instance - single instance
    private IRepositoryFactory _instance;

    // locker object for thread safe instance creation
    private static readonly object Locker = new object();
    

    // private constructor to restrict object creation from outside
    private RepositoryFactory() {}

    // static method for getting single instance of the factory
    public static IRepositoryFactory Instance() 
    {
        if(_instance != null) 
        {
            return _instance;
        }

        lock(Locker)
        {
            if(_instance == null) 
            {
                _instance = new RepositoryFactory();
            }
        }

        return _instance;
        
    }
    
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
