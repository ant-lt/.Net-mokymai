using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using WebApiF1.Controllers.P006;
using WebApiF1.Models;
using WebApiF1.Services;

namespace WebApiF1.Controllers.P003_Uzduotis2
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookManager _bookManager;
        private readonly ILogger<LoggingController> _logger;

        public BookController(IBookManager bookManager, ILogger<LoggingController> logger)
        {
            _bookManager = bookManager;
            _logger = logger;
        }

        /// <summary>
        /// Fetches all registered books in the SQLServer DB
        /// </summary>
        /// <returns>All books in DB</returns>
        /// <response code="200">OK</response>
        /// <response code="500">Error</response>
        [HttpGet("books",Name = "GetBooks")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<List<GetBookDto>> GetBooks()
        {
            _logger.LogInformation("GetBooks");
            return Ok( _bookManager.Get());
        }

        /// <summary>
        /// Fetch registered book with a specified ID from SQLServer DB
        /// </summary>
        /// <param name="id">Requested book ID</param>
        /// <returns>Book with specified ID</returns>
        /// <response code="200">OK</response>
        /// <response code="500">Error</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">NotFound</response>
        [HttpGet("{id}", Name = "GetBookById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetBookDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<GetBookDto> Get(int id)
        {
            _logger.LogInformation($"GetBook by id={id}");
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
        /// <response code="201">Book created</response>
        /// <response code="500">Error</response>
        /// <response code="400">Bad request</response>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateBookDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult Create(CreateBookDto req)
        {
            _logger.LogInformation($"CreateBook");

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


        /// <summary>
        /// Update book by id
        /// </summary>
        /// <param name="id"> Book Id</param>
        /// <param name="req"></param>
        /// <returns>Status code</returns>
        /// <response code="200">OK</response>
        /// <response code="500">Error</response>
        /// <response code="404">NotFound</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreateBookDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult Update(int id, UpdateBookDto req)
        {
            _logger.LogInformation($"Update book by id={id}");

            try
            {
                if (_bookManager.UpdateBook(id, req) == null)
                {
                    return NotFound();
                };
                return Ok();

            }

            catch (Exception e)
            {
                _logger.LogError(e, "HttpPut UpdateBookById(id = {0}) nuluzo {1} ", id, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Delete book by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status code</returns>
        /// <response code="200">OK</response>
        /// <response code="500">Error</response>
        /// <response code="404">NotFound</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreateBookDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult Delete(int id)
        {
            _logger.LogInformation($"HttpDelete Delete book by id={id}");

            try
            {
                if (_bookManager.DeleteBook(id) == null)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpDelete DeleteBookById(id = {0}) nuluzo {1} ", id, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    
    }
}
