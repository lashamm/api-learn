using api_learn.Models;

namespace api_learn.Services
{
    public interface IBookService
    {
        Task CreateAsync(Book book);

        Task UpdateBookAsync(int id, Book newBook);

        Task DeleteBookByIdAsync(int id);

        Task<IEnumerable<Book>> GetBookAsync();

        Task<Book?> GetBookByIdAsync(int id);
    }
}
