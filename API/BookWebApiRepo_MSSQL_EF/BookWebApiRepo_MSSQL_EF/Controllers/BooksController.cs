using Azure;
using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
using BookWebApiRepo_MSSQL_EF.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace BookWebApiRepo_MSSQL_EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepo;
        private readonly IBookWrapper _wrapper;
        private readonly ILogger<BooksController> _logger;

        public BooksController(IBookRepository bookRepository, IBookWrapper bookWrapper, ILogger<BooksController> logger) 
        { 
            _bookRepo = bookRepository;
            _wrapper = bookWrapper;
            _logger = logger;
        }

        /// <summary>
        /// Fetches all registered books in the SQLServer DB
        /// </summary>
        /// <returns>All books in DB</returns>
        /// <response code="200">OK</response>
        /// <response code="500">Internal server error</response>
        [HttpGet(Name = "GetBooks")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<IEnumerable<GetBookDto>>> GetBooks()
        {
            _logger.LogInformation($"{DateTime.Now} Executed GetBooks.");

            try
            {
                var books = await _bookRepo.GetAll();

                IEnumerable<GetBookDto>  getBookDto =books.Select(d => _wrapper.Bind(d)).ToList();

                return Ok(getBookDto);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpGet GetBooks nuluzo.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Fetch registered book with a specified ID from DB
        /// </summary>
        /// <param name="id">Requested book ID</param>
        /// <returns>Dish with specified ID</returns>
        /// <response code="200">OK</response>
        /// <response code="400">Book bad request description</response>
        /// <response code="404">Book not found </response>
        /// <response code="500">Internal server error</response>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET books/1
        ///     {
        ///         "id": 1,
        ///         "pavadinimasIrAutorius": "testas Vitas",
        ///         "leidybosMetai": 1999
        ///     }
        ///
        /// </remarks>
        [HttpGet("{id:int}", Name = "GetBookById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetBookDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<GetBookDto>> GetBookById(int id)
        {
            _logger.LogInformation($"{DateTime.Now} Executed GetBookById = {id}");

            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var book =  await _bookRepo.Get(d => d.Id == id);

                if (book == null)
                {
                    return NotFound();
                }

                return Ok(_wrapper.Bind(book));
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpGet GetBook by id ={id} nuluzo.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        /// <summary>
        /// Create new book record in SQLServer DB
        /// </summary>
        /// <param name="bookDto"> New book data</param>
        /// <returns>Created new book</returns>
        /// <response code="201">Book created</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Error</response>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST bookDto/
        ///     {
        ///         "pavadinimas": "string",
        ///         "autorius": "string",
        ///         "isleista": "2022-12-04T11:21:58.352Z",
        ///         "knygosTipas": "string" - allowed only from values list: Hardcover, Paperback, Electronic
        ///     }
        /// </remarks>
        [HttpPost("Create", Name = "CreateBook")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateBookDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<CreateBookDto>> CreateBook(CreateBookDto bookDto)
        {
            _logger.LogInformation($"{DateTime.Now} Executed CreateBook.");

            try
            {
                if (bookDto == null)
                {
                    return BadRequest();
                }


                Book book = _wrapper.Bind(bookDto);
                _bookRepo.Create(book);

                return CreatedAtRoute("GetBook", new { id = book.Id }, bookDto);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpPost CreateBook nuluzo");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Delete book by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status code</returns>
        /// <response code="204">Book deleted</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Book not found</response>
        /// <response code="500">Internal server error</response>
        [HttpDelete("delete/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult> DeleteBook(int id)
        {
            _logger.LogInformation($"{DateTime.Now} Executed DeleteBook id = {id}.");

            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }

                var book = await _bookRepo.Get(d => d.Id == id);

                if (book == null)
                {
                    return NotFound();
                }

                _bookRepo.Remove(book);

                return NoContent();
            }

            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpDelete DeleteBookById(id = {id}) nuluzo");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        /// <summary>
        /// Update book by id
        /// </summary>
        /// <param name="id"> Book Id</param>
        /// <param name="updateBookDto"></param>
        /// <returns>Status code</returns>
        /// <response code="204">Book updated</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">Book not found</response>
        /// <response code="500">Internal server error</response> 
        /// <remarks>
        /// Sample request:
        ///
        ///         PUT books/1
        ///         {
        ///             "id": 0,
        ///             "isleista": "2022-12-04T11:36:24.011Z",
        ///             "autorius": "string",
        ///             "pavadinimas": "string",
        ///             "knygosTipas": "string"  - allowed only from values list: Hardcover, Paperback, Electronic
        ///         }
        ///
        /// </remarks>
        [HttpPut("update/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult> UpdateBook(int id, UpdateBookDto updateBookDto)
        {
            _logger.LogInformation($"{DateTime.Now} Executed UpdateBook id = {id}.");

            try
            {
                if (id == 0 || updateBookDto == null)
                {
                    return BadRequest();
                }

                var foundBook = await _bookRepo.Get(d => d.Id == id);

                if (foundBook == null)
                {
                    return NotFound();
                }


                Book _bookUpdate = _wrapper.Bind(updateBookDto);

                foundBook.Author = _bookUpdate.Author;
                foundBook.Title = _bookUpdate.Title;
                foundBook.Years = _bookUpdate.Years;
                foundBook.CoverType = _bookUpdate.CoverType;

                await _bookRepo.Update(foundBook);

                return NoContent();
            }

            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpPut UpdateBookById(id = {id}) nuluzo.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        /// <summary>
        /// Filter books by name and author
        /// </summary>
        /// <param name="req"></param>
        /// <returns>Status code</returns>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">Book not found</response>
        /// <response code="500">Error</response>
        [HttpGet("Filter", Name = "Filter")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<IEnumerable<GetBookDto>>> Filter(FilterBookRequest req)
        {
            _logger.LogInformation("Books->Filter");
            try
            {
                if (req == null)
                {
                    return BadRequest();
                }

                var book = _wrapper.Bind(req);
                var books = await _bookRepo.Filter(book);
                if (books?.Count == 0)
                {
                    return NotFound();
                }

                IEnumerable<GetBookDto> getBookDto = books.Select(d => _wrapper.Bind(d)).ToList();

   
                return Ok(getBookDto);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} Books->Filter nuluzo.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }


    }
}
