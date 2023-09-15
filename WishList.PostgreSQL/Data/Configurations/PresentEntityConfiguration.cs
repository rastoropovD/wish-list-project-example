using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data.Configurations;

public sealed class PresentEntityConfiguration : IEntityTypeConfiguration<PresentEntity>
{
    public void Configure(EntityTypeBuilder<PresentEntity> builder)
    {
        builder.HasKey(e => e.Id);
    }
}