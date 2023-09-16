using WishList.API.CQRS.Query;
using WishList.PostgreSQL.Data;

namespace WishList.API.CQRS.User.GetById;

public sealed class GetByIdQueryHandler : IQueryHandler<GetByIdQuery, UserInfoDto>
{
    private readonly WishListDbContext _context;

    public GetByIdQueryHandler(WishListDbContext context)
    {
        _context = context;
    }
    
    public async Task<UserInfoDto> Handle(GetByIdQuery query)
    {
        // todo: read user info
        return new UserInfoDto();
    }
}