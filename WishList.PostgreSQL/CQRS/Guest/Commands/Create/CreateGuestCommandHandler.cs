using WishList.PostgreSQL.CQRS.Core.Command;

namespace WishList.PostgreSQL.CQRS.Guest.Commands.Create;

public sealed class CreateGuestCommandHandler : ICommandHandler<CreateGuestCommand>
{
    
    public Task Handle(CreateGuestCommand command)
    {
        throw new NotImplementedException();
    }

    public ValueTask DisposeAsync()
    {
        throw new NotImplementedException();
    }
}