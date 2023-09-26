namespace WishList.PostgreSQL.Data.Repositories.Guest;

public sealed class GuestRepository : IGuestRepository
{
    private readonly WishListDbContext _context;
    
    public GuestRepository(WishListDbContext context)
    {
        _context = context;
    }

    // repository methods
}