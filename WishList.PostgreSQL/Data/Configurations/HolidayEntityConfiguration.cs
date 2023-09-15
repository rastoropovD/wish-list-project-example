using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Configurations;

public sealed class HolidayEntityConfiguration : IEntityTypeConfiguration<HolidayEntity>
{
    public void Configure(EntityTypeBuilder<HolidayEntity> builder)
    {
        builder.HasKey(e => e.Id);
    }
}