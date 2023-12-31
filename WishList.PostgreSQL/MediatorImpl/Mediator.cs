using Microsoft.Extensions.DependencyInjection;
using WishList.PostgreSQL.CQRS.Core.Command;
using WishList.PostgreSQL.CQRS.Core.Query;

namespace WishList.PostgreSQL.MediatorImpl;

public sealed class Mediator : IMediator
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public Mediator(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }
    
    public async Task Send<TCommand>(TCommand command) where TCommand : ICommand
    {
        await using AsyncServiceScope scope = _serviceScopeFactory.CreateAsyncScope();
        IServiceProvider provider = scope.ServiceProvider;
        ICommandHandler<TCommand> handler = provider.GetRequiredService<ICommandHandler<TCommand>>();
        await handler.Handle(command);
    }

    public async Task<TResult> Send<TQuery, TResult>(TQuery query) where TQuery : IQuery
    {
        await using AsyncServiceScope scope = _serviceScopeFactory.CreateAsyncScope();
        IServiceProvider provider = scope.ServiceProvider;
        IQueryHandler<TQuery, TResult> handler = provider.GetRequiredService<IQueryHandler<TQuery, TResult>>();
        return await handler.Handle(query);
    }
}