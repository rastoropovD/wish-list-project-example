using WishList.PostgreSQL.PatternsLecture.Repository;

namespace WishList.PostgreSQL.PatternsLecture.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    Task Commit();
    IRepository Repository<TEntity>() where TEntity : class;
}