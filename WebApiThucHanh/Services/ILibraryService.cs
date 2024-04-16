
using WebApiThucHanh.Models;

namespace WebApiThucHanh.Services
{
    public interface ILibraryService
    {
        // Author Services
        Task<List<Author>> GetAuthorsAsync(); // GET All Authors
        Task<Author> GetAuthorAsync(Guid id, bool includeBooks = false); // GET Single Author
        Task<Author> AddAuthorAsync(Author author); // POST New Author
        Task<Author> UpdateAuthorAsync(Author author); // PUT Author
        Task<(bool, string)> DeleteAuthorAsync(Author author); // DELETE Author

        // Book Services
        Task<List<Book>> GetBooksAsync(); // GET All Books
        Task<Book> GetBookAsync(Guid id); // Get Single Book
        Task<Book> AddBookAsync(Book book); // POST New Book
        Task<Book> UpdateBookAsync(Book book); // PUT Book
        Task<(bool, string)> DeleteBookAsync(Book book); // DELETE Book

        //Bool author
        Task<List<BookAuthor>> GetBookAuthorsAsync(); // GET All BookAuthor
        Task<BookAuthor> GetBookAuthorsAsync(Guid id); // Get Single BookAuthor
        Task<BookAuthor> AdBookAuthorsAsync(BookAuthor BookAuthors); // POST New BookAuthor
        Task<BookAuthor> UpdateBookAuthorsAsync(BookAuthor BookAuthors); // PUT BookAuthor
        Task<(bool, string)> DeleteBookAuthorsAsync(BookAuthor BookAuthors); // DELETE BookAuthor

        // Publishers Services
        Task<List<Publishers>> GetPublishersAsync(); // GET All Publishers
        Task<Publishers> GetPublishersAsync(Guid id); // Get Single Publishers
        Task<Publishers> AddPublishersAsync(Publishers Publisher); // POST New Publishers
        Task<Publishers> UpdatePublishersAsync(Publishers Publishers); // PUT Publishers
        Task<(bool, string)> DeletePublishersAsync(Publishers Publishers); // DELETE Publishers
        Task<Publishers> GetPublishersAsync(object iD);
    }
}