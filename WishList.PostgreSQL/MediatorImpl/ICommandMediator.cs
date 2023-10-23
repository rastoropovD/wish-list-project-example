
using WishList.PostgreSQL.CQRS.Core.Command;

namespace WishList.PostgreSQL.MediatorImpl;

public interface ICommandMediator
{
    public Task Send<TCommand>(TCommand command) where TCommand : ICommand;
}