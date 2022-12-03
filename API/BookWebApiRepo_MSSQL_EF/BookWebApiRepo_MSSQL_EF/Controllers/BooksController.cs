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
        /// <response code="200">Viskas gerai</response>
        /// <response code="500">Klaida</response>
        [HttpGet("books", Name = "GetBooks")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<IEnumerable<GetBookDto>> GetBooks()
        {
            _logger.LogInformation($"{DateTime.Now} Executed GetBooks");
            return Ok(_bookRepo.GetAll()
                .Select(d => _wrapper.Bind(d))
                .ToList());
        }

        /// <summary>
        /// Fetch registered book with a specified ID from DB
        /// </summary>
        /// <param name="id">Requested book ID</param>
        /// <returns>Dish with specified ID</returns>
        /// <response code="200">OK</response>
        /// <response code="400">Book bad request description</response>
        /// <response code="404">Book not found </response>
        /// <response code="500">Error</response>
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
        [HttpGet("books/{id:int}", Name = "GetBook")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetBookDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<GetBookDto> GetDishById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var book = _bookRepo.Get(d => d.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok( _wrapper.Bind(book));
        }

        /// <summary>
        /// Create new book record in SQLServer DB
        /// </summary>
        /// <param name="req"> New book data</param>
        /// <returns>Created new book</returns>
        /// <response code="201">Book created</response>
        /// <response code="500">Error</response>
        /// <response code="400">Bad request</response>
        [HttpPost("books")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateBookDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<CreateBookDto> CreateBook(CreateBookDto bookDto)
        {
            if (bookDto == null)
            {
                return BadRequest();
            }


            Book book = _wrapper.Bind(bookDto);
            _bookRepo.Create(book);

            return CreatedAtRoute("GetBook", new { id = book.Id }, bookDto);
        }

        /// <summary>
        /// Delete book by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status code</returns>
        /// <response code="200">OK</response>
        /// <response code="500">Error</response>
        /// <response code="404">NotFound</response>
        [HttpDelete("books/delete/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult DeleteBook(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var book = _bookRepo.Get(d => d.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            _bookRepo.Remove(book);

            return NoContent();
        }

        /// <summary>
        /// Update book by id
        /// </summary>
        /// <param name="id"> Book Id</param>
        /// <param name="req"></param>
        /// <returns>Status code</returns>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">NotFound</response>
        /// <response code="500">Error</response>/// 
        [HttpPut("books/update/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult UpdateBook(int id, UpdateBookDto updateBookDto)
        {
            if (id == 0 || updateBookDto == null)
            {
                return BadRequest();
            }

            var foundBook = _bookRepo.Get(d => d.Id == id);

            if (foundBook == null)
            {
                return NotFound();
            }


            Book _bookUpdate = _wrapper.Bind(updateBookDto);

            //_bookUpdate.Id = id;
            foundBook.Author = _bookUpdate.Author;
            foundBook.Title = _bookUpdate.Title;
            foundBook.Years = _bookUpdate.Years;
            foundBook.CoverType = _bookUpdate.CoverType;

            _bookRepo.Update(foundBook);

            return NoContent();
        }

    }
}
