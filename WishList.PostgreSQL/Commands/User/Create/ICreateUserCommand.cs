using WishList.PostgreSQL.Commands.Core;

namespace WishList.PostgreSQL.Commands.User.Create;

public interface ICreateUserCommand : INoResponseAsyncCommand<CreateUserDto>
{
    
}