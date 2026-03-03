using api_learn.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_learn.Data
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext(DbContextOptions options) : base(options)
        {
        }
        public BookStoreContext() { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; } 
    }
}
