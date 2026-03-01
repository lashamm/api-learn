using api_learn.Data;
using api_learn.Models;
using Microsoft.EntityFrameworkCore;

namespace api_learn.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly BookStoreContext context;
        public AuthorService(BookStoreContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(Author author)
        {
            await context.authors.AddAsync(author);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAuthorByIdAsync(int id)
        {
            await context.authors.Where(a => a.Id == id).ExecuteDeleteAsync();
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Author>> GetAuthorAsync()
        {
            await context.authors.LoadAsync();
            return context.authors;
        }

        public async Task<Author?> GetAuthorByIdAsync(int id)
        {
            await context.authors.Where(a => a.Id == id).LoadAsync();
            return await context.authors.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAuthorAsync(int id, Author newAuthor)
        {
            await context.authors.Where(a => a.Id == id).ExecuteUpdateAsync(a => a
                .SetProperty(a => a.Name, newAuthor.Name)
                .SetProperty(a => a.Bio, newAuthor.Bio)
            );
        }
    }
}
