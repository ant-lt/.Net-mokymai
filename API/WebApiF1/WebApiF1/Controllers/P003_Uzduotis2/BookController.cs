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

            try
            {
                var books = _bookManager.Get();
                if ( books == null)
                {
                    return NotFound();
                }
                return Ok(books);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"HttpGet GetBooks nuluzo {DateTime.Now}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
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

            try
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
            catch (Exception e)
            {
                _logger.LogError(e, $"HttpGet GetBook by id ={id} nuluzo {DateTime.Now}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        /// <summary>
        /// Filter books by name and author
        /// </summary>
        /// <param name="req"></param>
        /// <returns>Status code</returns>
        /// <response code="200">OK</response>
        /// <response code="500">Error</response>
        /// <response code="404">NotFound</response>
        [HttpGet("filter", Name = "filter")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<List<GetBookDto>> Filter(FilterBookRequest req)
        {
            _logger.LogInformation("Books->Filter");
            if (req == null)
            {
                return BadRequest();
            }

            var books = _bookManager.Filter(req);

            if (books?.Count == 0)
            {
                return NotFound();
            }
            return Ok(books);

        }


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

            try
            {
                if (req == null)
                {
                    return BadRequest();
                }
                var book = _bookManager.Add(req);
                if (book == null)
                { 
                    return BadRequest();
                }

                //return CreatedAtRoute("CreateBook", book);
                return Ok(book);

            }

            catch (Exception e)
            {
                _logger.LogError(e, $"HttpPost CreateBook nuluzo {DateTime.Now}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }     
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UpdateBookDto))]
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
