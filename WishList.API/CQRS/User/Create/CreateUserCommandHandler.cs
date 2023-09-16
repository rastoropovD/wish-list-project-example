using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.Entities;

namespace WishList.API.CQRS.User.Create;

public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    private readonly WishListDbContext _context;

    public CreateUserCommandHandler(WishListDbContext context)
    {
        _context = context;
    }
    
    public async Task Handle(CreateUserCommand command)
    {
        UserEntity entity = new UserEntity();

        _context.Users.Add(entity);
        await _context.SaveChangesAsync();
    }
}