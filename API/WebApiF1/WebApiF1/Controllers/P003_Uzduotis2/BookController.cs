using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiF1.Models;
using WebApiF1.Services;

namespace WebApiF1.Controllers.P003_Uzduotis2
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookManager _bookManager;
        
        public BookController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        /// <summary>
        /// Fetches all registered books in the SQLServer DB
        /// </summary>
        /// <returns>All books in DB</returns>
        [HttpGet("books",Name = "GetBooks")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Book>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok( _bookManager.Get());
        }

        /// <summary>
        /// Fetch registered book with a specified ID from SQLServer DB
        /// </summary>
        /// <param name="id">Requested book ID</param>
        /// <returns>Book with specified ID</returns>
        [HttpGet("{id}", Name = "GetBookById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Book> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var book = _bookManager.Get(id);

            if (book == null)
            {
                return NotFound();
            }            
            return Ok(book);
        }

        /*
        [HttpGet("filter")]
        public ActionResult<List<GetBookDto>> Filter(FilterBookRequest req)
        {
            throw new NotImplementedException();
        }
        */

        /// <summary>
        /// Create new book record in SQLServer DB
        /// </summary>
        /// <param name="req"> New book data</param>
        /// <returns>Created new book</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Book))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Create(Book req)
        {            
            if (req == null) {
                return BadRequest();
            }

            /*
            var book = _bookManager.Add(req);
            
            if (book == null)
            {
                return BadRequest();
            }
            return CreatedAtRoute("GetBook", book);            
            */
            //return CreatedAtRoute(_bookManager.Add(req));
            return Ok(_bookManager.Add(req));
        }

        
        [HttpPut("{id}")]
        public ActionResult Update(int id, Book req)
        {
            _bookManager.UpdateBook(id, req);
            return Ok();
        }

        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            _bookManager.DeleteBook(id);
            return Ok();

        }
    

    }
}
