namespace WishList.PostgreSQL.Data.Repositories.Factory;

public interface IRepositoryFactory
{
    IRepository Instantiate<TEntity>(WishListDbContext context) where TEntity : class;
}