using api_learn.Data;
using api_learn.Models.DTOs;
using api_learn.Models.Entities;
using api_learn.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace api_learn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController(BookStoreContext bookStoreContext) : ControllerBase
    {
        private readonly BookStoreContext context = bookStoreContext;

        [HttpGet("GetBook")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBook()
        {
            return Ok(await context.Books.ToListAsync());
        }

        [HttpGet("GetBookById/{id}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBookById(int id)
        {
            Book? book = await context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost("AddBook")]
        public async Task<ActionResult<IEnumerable<Book>>> CreateBook(BookCreateDto book)
        {
            Book newBook = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                Price = book.Price,
                Author = book.Author,
                ReleaseYear = book.ReleaseYear,
                Genre = book.Genre,
                Pages = book.Pages,
                Publication = book.Publication,
                Quantity = book.Quantity,
                ISBN = book.ISBN,
                IsOriginal = book.IsOriginal,
                
            };
            await context.Books.AddAsync(book);
            await  context.SaveChangesAsync();

            var url = Url.Action(nameof(GetBookById));
            //return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
            return Created(nameof(GetBookById), new { id = book.Id });
        }

        [HttpDelete("DeleteBook")]
        public ActionResult<Book> DeleteBook(Book book)
        {
            var bookid = context.Find<Book>(book.Id);
            context.Books.Remove(bookid);
            context.SaveChanges();

            return NoContent();

            

            
        }
    }
}
