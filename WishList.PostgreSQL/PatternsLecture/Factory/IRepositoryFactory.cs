using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.PatternsLecture.Repository;

namespace WishList.PostgreSQL.PatternsLecture.Factory;

public interface IRepositoryFactory
{
    IRepository Instantiate<TEntity>(WishListDbContext context) where TEntity : class;
}