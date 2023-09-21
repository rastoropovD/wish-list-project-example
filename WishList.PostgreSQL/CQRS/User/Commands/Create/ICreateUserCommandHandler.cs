using WishList.PostgreSQL.CQRS.Core.Command;

namespace WishList.PostgreSQL.CQRS.User.Commands.Create;

public interface ICreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    
}