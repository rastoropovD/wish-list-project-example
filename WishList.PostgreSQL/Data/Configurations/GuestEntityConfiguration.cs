using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Configurations;

public sealed class GuestEntityConfiguration : IEntityTypeConfiguration<GuestEntity>
{
    public void Configure(EntityTypeBuilder<GuestEntity> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.UserId)
            .IsRequired();

        builder
            .Property(e => e.IsVisited)
            .HasDefaultValue(false)
            .IsRequired();

        builder
            .HasOne(g => g.SelectedPresent)
            .WithOne(p => p.PresentBy)
            .IsRequired(false);
    }
}