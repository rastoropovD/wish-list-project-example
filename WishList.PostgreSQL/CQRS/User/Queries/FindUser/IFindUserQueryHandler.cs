using WishList.PostgreSQL.CQRS.Core.Query;
using WishList.PostgreSQL.Dtos.User;

namespace WishList.PostgreSQL.CQRS.User.Queries.FindUser;

public interface IFindUserQueryHandler : IQueryHandler<FindUserQuery, UserInfoDto?>
{
    
}