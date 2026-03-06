using api_learn.Data;
using api_learn.Models.DTOs;
using api_learn.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("GetAuthorById/{id}")]
        public ActionResult GetAuthorById(int id)
        {
            var author = context.Authors.Find(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }
        [HttpPost("CreateAuthor")]
        public async Task<ActionResult<IEnumerable<Author>>> CreateBook(AuthorCreateDTO author)
        {
            Author newAuthor = new Author()
            {
                    Name = author.Name,
                    Bio = author.Bio,
            };
            await context.Authors.AddAsync(newAuthor);
            await context.SaveChangesAsync();

            var url = Url.Action(nameof(GetAuthorById));
            return Created(nameof(GetAuthorById), new { id = newAuthor.Id });
        }

            [HttpDelete("DeleteAuthor")]
        [HttpDelete("DeleteBook")]
        public ActionResult<Book> DeleteBook(Author author)
        {
            var bookid = context.Find<Author>(author.Id);
            context.Authors.Remove(bookid);
            context.SaveChanges();

            return NoContent();

        }
    }
}
