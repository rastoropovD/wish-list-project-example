using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Repositories;

public interface IUserRepository : IRepository
{
    Task Create(UserEntity user);
    Task<UserEntity?> FindSingle(string id);
}