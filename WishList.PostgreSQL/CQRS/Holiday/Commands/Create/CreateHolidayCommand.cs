using WishList.PostgreSQL.CQRS.Core.Command;

namespace WishList.PostgreSQL.CQRS.Holiday.Commands.Create;

public sealed record CreateHolidayCommand : ICommand
{
    public string Title { get; }
    public string Description { get; }
    public DateTime StartDate { get; }

    public CreateHolidayCommand(string title, string description, DateTime startDate)
    {
        Title = title;
        Description = description;
        StartDate = startDate;
    }
}