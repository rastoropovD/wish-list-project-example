using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Configurations;

public sealed class HolidayEntityConfiguration : IEntityTypeConfiguration<HolidayEntity>
{
    public void Configure(EntityTypeBuilder<HolidayEntity> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .HasIndex(e => e.StartDateTimestamp);

        builder
            .Property(e => e.Title)
            .HasMaxLength(50)
            .IsRequired();

        builder
            .Property(e => e.Description)
            .HasMaxLength(250)
            .IsRequired();

        builder
            .Property(e => e.StartDateTimestamp)
            .IsRequired();

        builder
            .Property(e => e.StartDate)
            .IsRequired();

        builder
            .HasMany(e => e.Guests)
            .WithOne(g => g.Holiday)
            .HasForeignKey(g => g.HolidayId);

        builder
            .HasMany(e => e.Presents)
            .WithOne(p => p.Holiday)
            .HasForeignKey(p => p.HolidayId);
    }
}