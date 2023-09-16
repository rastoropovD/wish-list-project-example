namespace WishList.PostgreSQL.Entities;

public sealed class PresentEntity
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsAssigned { get; set; }

    public UserEntity? PresentBy { get; set; }
    public HolidayEntity Holiday { get; set; }
}