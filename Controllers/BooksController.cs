using AngularCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace AngularCore.Controllers
{
    [Route("api/[controller]")]
    public class BooksController:Controller
    {
        private IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        //Create/Add a new Book
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book book)
        {
            try
            {
                if (book.Title != null && book.Author != null && book.Description != null)
                {
                    _service.AddNewBook(book);
                    return Ok(book);
                }
                return BadRequest("Book was not added.");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }          
        }

        // Read all Books
        [HttpGet("[action]")]
        public IActionResult GetBooks()
        {
            var allBooks = _service.GetAllBooks();
            return Ok(allBooks);
        }

        // Update and existing Book
        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book book)
        {
            _service.UpdateBook(id, book);
            return Ok(book);
        }

        // Delete a Book
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Ok();
        }

        // Get single Book by id
        [HttpGet("SingleBook/{id}")]
        public IActionResult GetbookById(int id)
        {
            var book = _service.GetBookById(id);
            return Ok(book);
        }
    }
}