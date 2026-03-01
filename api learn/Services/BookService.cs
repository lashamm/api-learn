using api_learn.Models;

namespace api_learn.Services
{
    public class BookService : IBookService
    {
        public Task CreateAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBookAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book?> GetBookByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBookAsync(int id, Book newBook)
        {
            throw new NotImplementedException();
        }
    }
}
