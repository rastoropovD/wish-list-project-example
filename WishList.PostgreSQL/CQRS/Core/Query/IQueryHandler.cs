namespace WishList.PostgreSQL.CQRS.Core.Query;

public interface IQueryHandler<in TQuery, TResult> : IAsyncDisposable where TQuery : IQuery
{
    Task<TResult> Handle(TQuery query);
}