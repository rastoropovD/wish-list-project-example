namespace WishList.PostgreSQL.Entities;

public sealed class PresentEntity
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsSelected { get; set; }
    public string? GuestId { get; set; }
    public string HolidayId { get; set; }

    public GuestEntity? PresentBy { get; set; }
    public HolidayEntity Holiday { get; set; }
}