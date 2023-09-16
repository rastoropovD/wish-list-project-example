namespace WishList.PostgreSQL.Entities;

public sealed class GuestEntity
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public bool IsVisited { get; set; }
    
    public UserEntity User { get; set; }
    public HolidayEntity Holiday { get; set; }
}