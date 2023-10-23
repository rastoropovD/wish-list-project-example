using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Repositories.Guest;

public sealed class GuestRepository : IGuestRepository
{
    private readonly WishListDbContext _context;
    
    public GuestRepository(WishListDbContext context)
    {
        _context = context;
    }

    public async Task Create(GuestEntity guest)
    {
        await _context.Guests.AddAsync(guest);
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }
}