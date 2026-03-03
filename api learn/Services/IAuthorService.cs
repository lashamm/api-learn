using api_learn.Models.Entities;

namespace api_learn.Services
{
    public interface IAuthorService
    {
            Task CreateAsync(Author author);
    
            Task UpdateAuthorAsync(int id, Author newAuthor);
    
            Task DeleteAuthorByIdAsync(int id);
    
            Task<IEnumerable<Author>> GetAuthorAsync();
    
            Task<Author?> GetAuthorByIdAsync(int id);
    }
}
