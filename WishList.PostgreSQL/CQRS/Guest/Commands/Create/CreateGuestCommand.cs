using WishList.PostgreSQL.CQRS.Core.Command;

namespace WishList.PostgreSQL.CQRS.Guest.Commands.Create;

public sealed record CreateGuestCommand : ICommand
{
    public string UserId { get; }
    public string HolidayId { get; }

    public CreateGuestCommand(string userId, string holidayId)
    {
        UserId = userId;
        HolidayId = holidayId;
    }
}