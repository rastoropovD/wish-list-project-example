using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WishList.PostgreSQL.Entities;

namespace WishList.PostgreSQL.Data;

public sealed class WishListDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; init; }
    public DbSet<HolidayEntity> Holidays { get; init; }
    public DbSet<PresentEntity> Presents { get; init; }
    public DbSet<GuestEntity> Guests { get; init; }
    
    public WishListDbContext(DbContextOptions<WishListDbContext> options): base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}