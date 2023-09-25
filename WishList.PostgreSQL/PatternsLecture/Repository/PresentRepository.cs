using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.PatternsLecture.Repository;

public sealed class PresentRepository : IRepository
{
    private readonly WishListDbContext _context;
    
    public PresentRepository(WishListDbContext context)
    {
        _context = context;
    }

    // repository methods

}