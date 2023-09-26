using WishList.PostgreSQL.CQRS.Core.Command;
using WishList.PostgreSQL.Data.Repositories;
using WishList.PostgreSQL.Data.UnitOfWork;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.CQRS.User.Commands.Create;

public sealed class CreateUserCommandHandler : ICreateUserCommandHandler
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    async Task ICommandHandler<CreateUserCommand>.Handle(CreateUserCommand command)
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

        await ((IUserRepository) _unitOfWork.Repository<UserEntity>()).Create(user);

        await _unitOfWork.Commit();
    }
}