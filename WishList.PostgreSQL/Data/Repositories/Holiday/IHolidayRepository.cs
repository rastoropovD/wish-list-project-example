using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Repositories.Holiday;

public interface IHolidayRepository : IRepository
{
    Task Create(HolidayEntity holiday);
}