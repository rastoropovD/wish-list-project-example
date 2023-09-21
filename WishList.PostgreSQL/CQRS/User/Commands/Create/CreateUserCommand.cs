using WishList.PostgreSQL.CQRS.Core.Command;

namespace WishList.PostgreSQL.CQRS.User.Commands.Create;

public sealed record CreateUserCommand : ICommand
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string PasswordHash { get; }

    public CreateUserCommand(string firstName, string lastName, string email, string passwordHash)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordHash = passwordHash;
    }
    
}