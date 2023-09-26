using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Repositories;

public sealed class UserRepository : IUserRepository
{
    private readonly WishListDbContext _context;
    
    public UserRepository(WishListDbContext context)
    {
        _context = context;
    }

    public async Task Create(UserEntity user)
    {
        await _context.Users.AddAsync(user);
    }

    public async Task<UserEntity?> FindSingle(string email)
    {
        return await _context.Users.SingleOrDefaultAsync(p => p.Email == email);
    }

}