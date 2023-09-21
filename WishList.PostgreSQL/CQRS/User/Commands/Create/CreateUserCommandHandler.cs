using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.CQRS.User.Commands.Create;

public sealed class CreateUserCommandHandler : ICreateUserCommandHandler
{
    private readonly WishListDbContext _context;

    public CreateUserCommandHandler(WishListDbContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateUserCommand command)
    {
        DateTime now = DateTime.UtcNow;
        
        UserEntity user = new UserEntity()
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            PasswordHash = command.PasswordHash,
            CreatedAtTimestamp = now.Ticks,
            CreatedAt = now
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();
    }
}