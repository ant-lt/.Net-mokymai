using BookWebApiRepo_MSSQL_EF.Enums;
using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;

namespace BookWebApiRepo_MSSQL_EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStockController : ControllerBase
    {
        private readonly IBookRepository _bookRepo;
        private readonly ILogger<BookStockController> _logger;

        public BookStockController(IBookRepository bookRepository, ILogger<BookStockController> logger)
        {
            _bookRepo= bookRepository;
            _logger= logger;
        }


        /// <summary>
        /// Reduce book by qnt on stock by id
        /// </summary>
        /// <param name="qnt">Reduce quantity</param>
        /// <param name="id"> Book Id</param>
        /// <returns>Status code</returns>
        /// <response code="200">OK. Book quantity reduced.</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Client could not authenticate a request</response>       
        /// <response code="404">Book not found</response>
        /// <response code="500">Internal server error</response> 
        [HttpPut("reduce/{qnt:int}/stock/{id:int}/book")]
        [Authorize(Roles = "Administrator,Secretary")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult> ReduceBookOnStock(int qnt, int id)
        {
            _logger.LogInformation($"{DateTime.Now} Executed ReduceBookOnStock for Book id = {id} Quantity= {qnt}.");

            try
            {
                if (id == 0 || qnt == null)
                {
                    return BadRequest();
                }

                var book = await _bookRepo.GetAsync(d => d.Id == id);

                if (book == null)
                {
                    _logger.LogInformation("Book with id {id} not found", id);
                    return NotFound();
                }

                var delta = book.OwnedQty - qnt;

                if ( delta < 0)
                {
                    _logger.LogInformation("Book with id {id} not found", id);
                    return BadRequest($"Insufficient book quantity {delta}");
                }


                book.OwnedQty = delta;


                await _bookRepo.UpdateAsync(book);

                return Ok();
            }

            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpPut ReduceBookOnStock Book (id = {id}) Quantity= {qnt} nuluzo.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Add book by qnt on stock by id
        /// </summary>
        /// <param name="qnt">Add quantity</param>
        /// <param name="id"> Book Id</param>
        /// <returns>Status code</returns>
        /// <response code="200">OK. Book quantity increased.</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Client could not authenticate a request</response>       
        /// <response code="404">Book not found</response>
        /// <response code="500">Internal server error</response> 
        [HttpPut("add/{qnt:int}/stock/{id:int}/book")]
        [Authorize(Roles = "Administrator,Secretary")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult> AddBookOnStock(int qnt, int id)
        {
            _logger.LogInformation($"{DateTime.Now} Executed AddBookOnStock for Book id = {id} Quantity= {qnt}.");

            try
            {
                if (id == 0 || qnt == null)
                {
                    return BadRequest();
                }

                var book = await _bookRepo.GetAsync(d => d.Id == id);

                if (book == null)
                {
                    _logger.LogInformation("Book with id {id} not found", id);
                    return NotFound();
                }


                book.OwnedQty += qnt;

                await _bookRepo.UpdateAsync(book);

                return Ok();
            }

            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpPut AddBookOnStock Book (id = {id}) Quantity= {qnt} nuluzo.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
