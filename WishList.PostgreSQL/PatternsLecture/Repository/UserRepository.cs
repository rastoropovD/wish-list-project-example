using Microsoft.EntityFrameworkCore;
using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.PatternsLecture.Repository;

public sealed class UserRepository : IRepository
{
    private readonly WishListDbContext _context;
    
    public UserRepository(WishListDbContext context)
    {
        _context = context;
    }

    // repository methods

}