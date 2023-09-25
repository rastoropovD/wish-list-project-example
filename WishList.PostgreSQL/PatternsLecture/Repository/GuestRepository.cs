using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.PatternsLecture.Repository;

public sealed class GuestRepository : IRepository
{
    private readonly WishListDbContext _context;
    
    public GuestRepository(WishListDbContext context)
    {
        _context = context;
    }

    // repository methods
}