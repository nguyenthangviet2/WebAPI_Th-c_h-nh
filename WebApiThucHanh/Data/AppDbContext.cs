using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using WebApiThucHanh.Models;

namespace   WebApiThucHanh.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; } 
        public DbSet<Publishers> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            // co the dinh nghia moi quan he giua cac table bang Fluent API
            modelbuilder.Entity<BookAuthor>()
            .HasOne(b => b.Book)
            .WithMany(ba => ba.bookAuthors)
            .HasForeignKey(bi => bi.BookID);
            modelbuilder.Entity<BookAuthor>()
            .HasOne(b => b.Author)
            .WithMany(ba => ba.BookAuthors)
            .HasForeignKey(bi => bi.AuthorID);
        }
    }
}
