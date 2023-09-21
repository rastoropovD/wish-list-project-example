namespace WishList.PostgreSQL.Entities;

public sealed class HolidayEntity
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public long StartDateTimestamp { get; set; }
    public DateTime StartDate { get; set; }

    public ICollection<GuestEntity> Guests { get; set; }
    public ICollection<PresentEntity> Presents { get; set; }
}