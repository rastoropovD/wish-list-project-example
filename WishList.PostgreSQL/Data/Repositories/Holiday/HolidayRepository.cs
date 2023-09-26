namespace WishList.PostgreSQL.Data.Repositories.Holiday;

public sealed class HolidayRepository : IHolidayRepository
{
    private readonly WishListDbContext _context;
    
    public HolidayRepository(WishListDbContext context)
    {
        _context = context;
    }

    // repository methods

}