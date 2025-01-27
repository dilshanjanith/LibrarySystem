using LibrarySystem.Application.Book;
using LibrarySystem.Model;
using LibrarySystem.Model.ValitateBooks;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(BookReposetory.GetAllBooks());
        }

        [HttpGet("{id}")]
        [Book_IdValidation]
        public IActionResult GetBook(int id) 
        {
            return Ok(BookReposetory.GetABook(id));
        }

        [HttpPost]
        public IActionResult CreateNewBook(BookDto book)
        {
            if (book == null) {
                return BadRequest();
            }

            var newBooks = BookReposetory.CreateNewBook(book);
            return CreatedAtAction(nameof(GetBook), new
            {
                Id = newBooks.Max(b => b.BookId),
            }, newBooks);

        }

        [HttpPatch("{id}")]
        [Book_IdValidation]
        public IActionResult UpdateBook(int id, BookDto book) 
        {
           BookReposetory.UpdateBook(book);
           return NoContent();
        }

        [HttpDelete("{id}")]
        [Book_IdValidation]
        public IActionResult DeleteBook(int id)
        {
            BookReposetory.DeleteBook(id);
            return NoContent();
        }


    }
}
