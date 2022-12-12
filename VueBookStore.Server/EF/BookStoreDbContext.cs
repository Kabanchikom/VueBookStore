using Microsoft.EntityFrameworkCore;
using VueBookStore.Server.Areas.Author.Models;
using VueBookStore.Server.Areas.Manufacturer.Models;
using VueBookStore.Server.Areas.Order.Models;
using VueBookStore.Server.Areas.Product.Models;

namespace VueBookStore.Server.EF;

public class BookStoreDbContext : DbContext
{
    public DbSet<ProductCard> Products { get; set; }
    public DbSet<BookCard> Books { get; set; }
    public DbSet<StationeryCard> Stationary { get; set; }
    public DbSet<ManufacturerCard> Manufacturers { get; set; }
    public DbSet<OrderCard> Orders { get; set; }
    public DbSet<AuthorCard> Authors { get; set; }

    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductCard>()
            .Property(x => x.Rating)
            .HasPrecision(3, 2);
    }
}