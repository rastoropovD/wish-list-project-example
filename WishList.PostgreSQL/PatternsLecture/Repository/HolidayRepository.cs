using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.PatternsLecture.Repository;

public sealed class HolidayRepository : IRepository
{
    private readonly WishListDbContext _context;
    
    public HolidayRepository(WishListDbContext context)
    {
        _context = context;
    }

    // repository methods

}