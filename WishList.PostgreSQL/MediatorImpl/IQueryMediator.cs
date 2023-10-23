using WishList.PostgreSQL.CQRS.Core.Query;

namespace WishList.PostgreSQL.MediatorImpl;

public interface IQueryMediator
{
    public Task<TResult> Send<TQuery, TResult>(TQuery query) where TQuery : IQuery;
}