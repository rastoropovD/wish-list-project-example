using WishList.PostgreSQL.CQRS.Core.Command;
using WishList.PostgreSQL.Data.Repositories.Holiday;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.CQRS.Holiday.Commands.Create;

public sealed class CreateHolidayCommandHandler : ICommandHandler<CreateHolidayCommand>
{
    private readonly IHolidayRepository _holidayRepository;

    public CreateHolidayCommandHandler(IHolidayRepository holidayRepository)
    {
        _holidayRepository = holidayRepository;
    }
    
    public async Task Handle(CreateHolidayCommand command)
    {
        HolidayEntity holidayEntity = new HolidayEntity()
        {
            Id = Guid.NewGuid().ToString(),
            Title = command.Title,
            Description = command.Description,
            StartDateTimestamp = command.StartDate.Ticks,
            StartDate = command.StartDate
        };

        await _holidayRepository.Create(holidayEntity);
    }

    public async ValueTask DisposeAsync()
    {
        await _holidayRepository.DisposeAsync();
    }
}