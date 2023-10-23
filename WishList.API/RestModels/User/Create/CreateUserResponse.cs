namespace WishList.API.RestModels.User.Create;

public sealed record CreateUserResponse
{
    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string AccessToken { get; }

    public CreateUserResponse(string id, string firstName, string lastName, string email, string accessToken)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        AccessToken = accessToken;
    }
}