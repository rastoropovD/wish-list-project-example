using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Repositories.Guest;

public interface IGuestRepository : IRepository
{
    Task Create(GuestEntity guest);
}