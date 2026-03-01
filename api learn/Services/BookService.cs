using api_learn.Data;
using api_learn.Models;
using Microsoft.EntityFrameworkCore;

namespace api_learn.Services
{
    public class BookService : IBookService
    {
        private readonly BookStoreContext context;
        public BookService(BookStoreContext context)
        {
            this.context = context;
        }
        public async Task CreateAsync(Book book)
        {
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();
        }

        public async Task DeleteBookByIdAsync(int id)
        {
            await context.Books.Where(b => b.Id == id).ExecuteDeleteAsync();
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetBookAsync()
        {
            await context.Books.Include(b => b.Author).LoadAsync();
            return await context.Books.ToListAsync();
        }

        public async Task<Book?> GetBookByIdAsync(int id)
        {
            await context.Books.Include(b => b.Author).Where(b => b.Id == id).LoadAsync();
            return await context.Books.Where(b => b.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateBookAsync(int id, Book newBook)
        {
            await context.Books.Where(b => b.Id == id).ExecuteUpdateAsync(b => b
                .SetProperty(b => b.Title, newBook.Title)
                .SetProperty(b => b.Description, newBook.Description)
            );
        }
    }
}
