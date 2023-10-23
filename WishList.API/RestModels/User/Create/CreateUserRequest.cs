namespace WishList.API.RestModels.User.Create;

public sealed record CreateUserRequest
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }
}