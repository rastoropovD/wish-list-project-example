namespace WishList.PostgreSQL.CQRS.Core.Command;

public interface ICommandHandler<in TCommand> : IAsyncDisposable where TCommand : ICommand
{
    Task Handle(TCommand command);
}