using BookStoreServer.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreServer.WebApi.Context;

public sealed class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=QUADESH;Initial Catalog=BookStoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCategory> BookCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().OwnsOne(p => p.Price, price =>
        {
            price.Property(p => p.Value).HasColumnType("money");
            price.Property(p => p.Currency).HasMaxLength(5); // Assuming you want a max length for Currency
        });//Value Object

        modelBuilder.Entity<BookCategory>().HasKey(p => new { p.BookId, p.CategoryId });
        //Composite Key

        //Seed Data => Development sürecinde eline veri olmasını sağlar ki üzerinde çalışılabilsin.
        //Canlıya aldığında değişmeyecek ve database de kayıt olarak tutman gereken verilerin olmasını sağlar.

        modelBuilder.Entity<Category>().HasData( //seed data
          new Category { Id = 1, Name = "Horror", IsActive = true, IsDeleted = false },
          new Category { Id = 2, Name = "Science-Fiction", IsActive = true, IsDeleted = false },
          new Category { Id = 3, Name = "History", IsActive = true, IsDeleted = false },
          new Category { Id = 4, Name = "Literature", IsActive = true, IsDeleted = false },
          new Category { Id = 5, Name = "Kids", IsActive = true, IsDeleted = false },
          new Category { Id = 6, Name = "Psychology", IsActive = true, IsDeleted = false },
          new Category { Id = 7, Name = "Technology", IsActive = true, IsDeleted = false },
          new Category { Id = 8, Name = "Philosophy", IsActive = true, IsDeleted = false },
          new Category { Id = 9, Name = "Science", IsActive = true, IsDeleted = false },
          new Category { Id = 10, Name = "Art", IsActive = true, IsDeleted = false },
          new Category { Id = 11, Name = "Sports", IsActive = true, IsDeleted = false },
          new Category { Id = 12, Name = "Travel", IsActive = true, IsDeleted = false },
          new Category { Id = 13, Name = "Magazine", IsActive = true, IsDeleted = false },
          new Category { Id = 14, Name = "Humour", IsActive = true, IsDeleted = false },
          new Category { Id = 15, Name = "Self-Improvement", IsActive = true, IsDeleted = false },
          new Category { Id = 16, Name = "World-Cuisines", IsActive = true, IsDeleted = false },
          new Category { Id = 17, Name = "Hobby", IsActive = true, IsDeleted = false },
          new Category { Id = 18, Name = "Reference", IsActive = true, IsDeleted = false },
          new Category { Id = 19, Name = "Education", IsActive = true, IsDeleted = false },
          new Category { Id = 20, Name = "Games", IsActive = true, IsDeleted = false});
    }
}