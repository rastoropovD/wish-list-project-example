using WishList.API.CQRS.Query;

namespace WishList.API.CQRS.User.GetById;

public sealed record GetByIdQuery : IQuery
{
    public string Id { get; }

    public GetByIdQuery(string id)
    {
        Id = id;
    }
}