using api_learn.Data;
using api_learn.Models;
using api_learn.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_learn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController(BookStoreContext bookStoreContext) : ControllerBase
    {
        private readonly BookStoreContext context = bookStoreContext;
        //public BooksController(BookStoreContext context)
        //{
        //    this.context = context;
        //}
        [HttpGet("GetBook")]
        public IEnumerable<Book> GetBook()
        {
            return [];
        }

        [HttpGet("GetBookById/{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            Book? book = context.Books.Find(id); // nullable Book

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }
        //    public Book GetBookByIdd(int id)
        //{
            
        //}
        }
}
