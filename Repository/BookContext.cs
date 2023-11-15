using Microsoft.EntityFrameworkCore;
using Dotnet_Books.models;

namespace Dotnet_Books.Repository
{
    public class BookContext : DbContext, IBookContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) {}

        public DbSet<Author> Authors { get; set; } = null!;

        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=127.0.0.1;Database=BookStore;User=SA;Password=Dot123456!";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne<Author>(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}