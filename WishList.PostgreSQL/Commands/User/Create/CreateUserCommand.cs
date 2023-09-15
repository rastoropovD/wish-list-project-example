using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Commands.User.Create;

public sealed class CreateUserCommand : ICreateUserCommand
{
    private readonly WishListDbContext _context;

    public CreateUserCommand(WishListDbContext context)
    {
        _context = context;
    }
    
    public async Task Execute(CreateUserDto data)
    {
        UserEntity entity = new UserEntity();

        _context.Users.Add(entity);
        await _context.SaveChangesAsync();
    }
}