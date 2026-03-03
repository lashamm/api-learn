using api_learn.Data;
using api_learn.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_learn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController(BookStoreContext bookStoreContext) : ControllerBase
    {
        private readonly BookStoreContext context = bookStoreContext;

        [HttpGet("Author")]
        public IEnumerable<Author> GetAuthor()
        {
            return [];
        }

        [HttpGet("GetBookById/{id}")]
        public ActionResult GetBookById(int id)
        {
            var book = context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }
}
