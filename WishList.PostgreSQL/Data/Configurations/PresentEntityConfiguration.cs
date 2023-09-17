using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Configurations;

public sealed class PresentEntityConfiguration : IEntityTypeConfiguration<PresentEntity>
{
    public void Configure(EntityTypeBuilder<PresentEntity> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder
            .Property(e => e.Title)
            .HasMaxLength(50)
            .IsRequired();

        builder
            .Property(e => e.Description)
            .HasMaxLength(250)
            .IsRequired();

        builder
            .Property(e => e.IsSelected)
            .HasDefaultValue(false)
            .IsRequired();

        builder
            .HasOne(e => e.Holiday)
            .WithMany(h => h.Presents)
            .HasForeignKey(e => e.HolidayId);

        builder
            .HasOne(e => e.PresentBy)
            .WithOne(g => g.SelectedPresent)
            .IsRequired(false);
    }
}