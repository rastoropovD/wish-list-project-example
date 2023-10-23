namespace WishList.PostgreSQL.Data.Repositories.Present;

public sealed class PresentRepository : IPresentRepository
{
    private readonly WishListDbContext _context;
    
    public PresentRepository(WishListDbContext context)
    {
        _context = context;
    }

    // repository methods

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }
}