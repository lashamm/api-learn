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

        Task IAuthorService.CreateAsync(Author author)
        {
            throw new NotImplementedException();
        }

        Task IAuthorService.DeleteAuthorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Author>> IAuthorService.GetAuthorAsync()
        {
            throw new NotImplementedException();
        }

        Task<Author?> IAuthorService.GetAuthorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IAuthorService.UpdateAuthorAsync(int id, Author newAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
