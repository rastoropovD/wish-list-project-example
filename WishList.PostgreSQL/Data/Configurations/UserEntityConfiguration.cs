using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Configurations;

public sealed class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .HasIndex(e => e.Email)
            .IsUnique();

        builder
            .HasIndex(e => e.CreatedAtTimestamp);

        builder
            .Property(e => e.Name)
            .IsRequired();

        builder
            .Property(e => e.Surname)
            .IsRequired();
        
        builder
            .Property(e => e.Email)
            .IsRequired();
        
        builder
            .Property(e => e.PasswordHash)
            .IsRequired();

        builder
            .Property(e => e.CreatedAtTimestamp)
            .IsRequired();

        builder
            .Property(e => e.CreatedAt)
            .IsRequired();

        builder
            .HasMany(e => e.GuestIn)
            .WithOne(g => g.User)
            .HasForeignKey(g => g.UserId);
    }
}