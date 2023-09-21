namespace WishList.PostgreSQL.Entities;

public sealed class GuestEntity
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public string HolidayId { get; set; }
    public string? SelectedPresentId { get; set; }
    public bool IsVisited { get; set; }
    
    public UserEntity User { get; set; }
    public HolidayEntity Holiday { get; set; }
    public PresentEntity? SelectedPresent { get; set; }
    
}