using LibrarySystem.Model;
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
            return Ok("Returning All Books!");
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id) 
        {
            return Ok($"Retunrn Book Id: {id}");
        }

        [HttpPost]
        public IActionResult CreateNewBook(BookDto book)
        {
            return Ok("Book Created SuccessFully");
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateBook(BookDto book) 
        {
            return Ok("Book Updated SuccessFully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            return Ok($"Book Deleted SuccessFully  Id: {id}");
        }


    }
}
