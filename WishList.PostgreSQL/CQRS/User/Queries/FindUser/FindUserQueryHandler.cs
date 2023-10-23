using Microsoft.EntityFrameworkCore;
using WishList.PostgreSQL.CQRS.Core.Query;
using WishList.PostgreSQL.Data;
using WishList.PostgreSQL.Data.Repositories;
using WishList.PostgreSQL.Data.UnitOfWork;
using WishList.PostgreSQL.Dtos.User;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.CQRS.User.Queries.FindUser;

public sealed class FindUserQueryHandler : IQueryHandler<FindUserQuery, UserInfoDto?>
{
    private readonly IUserRepository _repository;

    public FindUserQueryHandler(IUserRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<UserInfoDto?> Handle(FindUserQuery query)
    {
        UserEntity? entity = await _repository.FindSingle(query.Email);

        return entity != null ? new UserInfoDto(entity.Id, entity.FirstName, entity.LastName, entity.Email) : default;
    }

    public async ValueTask DisposeAsync()
    {
        await _repository.DisposeAsync();
    }
}