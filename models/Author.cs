namespace Dotnet_Books.models
{
    using System.ComponentModel.DataAnnotations;
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string? Name { get; set; }

        public ICollection<Book> Books { get; set; } = null!;
    }
}