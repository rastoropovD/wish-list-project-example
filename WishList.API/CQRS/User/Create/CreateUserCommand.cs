namespace WishList.API.CQRS.User.Create;

public sealed record CreateUserCommand : ICommand
{
    // create user properties

    public string FirstName { get; }

    public CreateUserCommand(string firstName)
    {
        FirstName = firstName;
    }
}