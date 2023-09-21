namespace WishList.PostgreSQL.Entities;

public sealed class UserEntity
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public long CreatedAtTimestamp { get; set; }
    public DateTime CreatedAt { get; set; }

    public ICollection<GuestEntity> GuestIn { get; set; }
}