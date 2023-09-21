using WishList.PostgreSQL.CQRS.Core.Query;

namespace WishList.PostgreSQL.CQRS.User.Queries.FindUser;

public sealed record FindUserQuery : IQuery
{
    public string Email { get; }

    public FindUserQuery(string email)
    {
        Email = email;
    }
}