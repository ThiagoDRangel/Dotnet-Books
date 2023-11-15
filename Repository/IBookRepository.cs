using Dotnet_Books.models;

namespace Dotnet_Books.Repository
{
    public interface IBookRepository
    {
        Author AddAuthor(Author author);

        IEnumerable<Author> GetAuthors();

        Book AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}