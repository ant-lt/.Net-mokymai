using BookWebApiRepo_MSSQL_EF.Data;
using BookWebApiRepo_MSSQL_EF.Enums;
using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace BookWebApiRepo_MSSQL_EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationRepository _reservationRepo;
        private readonly ILogger<ReservationController> _logger;

        public ReservationController(IReservationRepository reservationRepository, ILogger<ReservationController> logger )
        {
            _reservationRepo= reservationRepository;
            _logger= logger;
        }

        /// <summary>
        /// Fetches all books reservations
        /// </summary>
        /// <returns>Fetches all books reservations</returns>
        /// <response code="200">OK</response>
        /// <response code="401">Client could not authenticate a request</response>
        /// <response code="500">Internal server error</response>
        [HttpGet(Name = "GetReservations")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Reservation>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetAllReservations()
        {
            _logger.LogInformation($"{DateTime.Now} Executed GetReservations.");

            try
            {
                var reservations = await _reservationRepo.GetAll();

                IEnumerable<Reservation> getBookReservation = reservations.ToList();

                return Ok(getBookReservation);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpGet GetReservations nuluzo.");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Create new book reservation for user in SQLServer DB
        /// </summary>
        /// <param name="bookId">Reserved book Id</param>
        /// <param name="userName">userName</param>
        /// <returns>Created new reservation</returns>
        /// <response code="201">Reservation created</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Client could not authenticate a request</response>
        /// <response code="403">Forbidden</response>
        /// <response code="500">Error</response>
        [HttpPost("Create/{bookId:int}", Name = "CreateReservation")]
        [Authorize(Roles = "Administrator,Librarian")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ReservationResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<ReservationResponse>> CreateReservation(int bookId, string userName)
        {
            _logger.LogInformation($"{DateTime.Now} Executed CreateReservation.");

            try
            {
                
                if (bookId <= 0 || userName.Length <= 0 )
                {
                    return BadRequest();
                }


                var  bookReservation = await _reservationRepo.Reserve(bookId, userName);


                return CreatedAtRoute("CreateReservation", new { id = bookReservation.ReservationId }, bookReservation);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpPost CreateReservation nuluzo");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        ///  Return book for user in SQLServer DB
        /// </summary>
        /// <param name="bookId">Reserved book Id</param>
        /// <param name="userName">userName</param>
        /// <returns>Return book</returns>
        /// <response code="201">Book return</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Client could not authenticate a request</response>
        /// <response code="403">Forbidden</response>
        /// <response code="500">Error</response>
        [HttpPost("Return/{bookId:int}", Name = "ReturnBook")]
        [Authorize(Roles = "Administrator,Librarian")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ReservationResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<ReservationResponse>> ReturnBook(int bookId, string userName)
        {
            _logger.LogInformation($"{DateTime.Now} Executed ReturnBook.");

            try
            {

                if (bookId <= 0 || userName.Length <= 0)
                {
                    return BadRequest();
                }


                var bookReturn = await _reservationRepo.Return(bookId, userName);


                return Ok(bookReturn);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpPost BookReturn nuluzo");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


    }
}
