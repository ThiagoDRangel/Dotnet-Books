using Dotnet_Books.models;

namespace Dotnet_Books.Repository
{
    public interface IBookContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public int SaveChanges();
    }
}