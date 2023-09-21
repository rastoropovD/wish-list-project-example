namespace WishList.PostgreSQL.Dtos.User;

public sealed record UserInfoDto
{
    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }

    public UserInfoDto(string id, string firstName, string lastName, string email)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}