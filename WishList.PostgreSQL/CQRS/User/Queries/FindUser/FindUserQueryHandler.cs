using Microsoft.EntityFrameworkCore;
using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.Dtos.User;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.CQRS.User.Queries.FindUser;

public sealed class FindUserQueryHandler : IFindUserQueryHandler
{
    private readonly WishListDbContext _context;

    public FindUserQueryHandler(WishListDbContext context)
    {
        _context = context;
    }
    
    public async Task<UserInfoDto?> Handle(FindUserQuery query)
    {
        UserEntity? entity = await _context.Users.FirstOrDefaultAsync(p => p.Email == query.Email);

        return entity != null ? new UserInfoDto(entity.Id, entity.FirstName, entity.LastName, entity.Email) : default;
    }
}