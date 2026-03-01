using Microsoft.EntityFrameworkCore;

namespace api_learn.Data
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext(DbContextOptions options) : base(options)
        {
        }
        public BookStoreContext() { }

        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.Author> authors { get; set; } 
    }
}
