using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Repositories.Holiday;

public sealed class HolidayRepository : IHolidayRepository
{
    private readonly WishListDbContext _context;
    
    public HolidayRepository(WishListDbContext context)
    {
        _context = context;
    }


    public async Task Create(HolidayEntity holiday)
    {
        await _context.Holidays.AddAsync(holiday);
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }
}