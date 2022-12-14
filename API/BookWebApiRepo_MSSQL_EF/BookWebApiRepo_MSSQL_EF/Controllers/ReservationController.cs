using BookWebApiRepo_MSSQL_EF.Data;
using BookWebApiRepo_MSSQL_EF.Enums;
using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
using BookWebApiRepo_MSSQL_EF.Services;
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
      //  private readonly IBookReservationManager _bookReservationManager;
        private readonly IReservationWrapper _reservationWrapper;

        private readonly ILogger<ReservationController> _logger;

        public ReservationController(IReservationRepository reservationRepository, /*IBookReservationManager bookReservationManager,*/ ILogger<ReservationController> logger, IReservationWrapper reservationWrapper)
        {
            _reservationRepo= reservationRepository;
      //      _bookReservationManager= bookReservationManager;
            _logger= logger;
            _reservationWrapper = reservationWrapper;
        }

        /// <summary>
        /// Fetches all books reservations
        /// </summary>
        /// <returns>Fetches all books reservations</returns>
        /// <response code="200">OK</response>
        /// <response code="401">Client could not authenticate a request</response>
        /// <response code="500">Internal server error</response>
        [HttpGet("GetAllBooksReservations", Name = "GetAllBooksReservations")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ReservationResponse>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<IEnumerable<ReservationResponse>>> GetAllBooksReservations()
        {
            _logger.LogInformation($"{DateTime.Now} Executed GetAllBooksReservations.");

            try
            {
                //var reservations = await _bookReservationManager.GetAll();
                var reservations = await _reservationRepo.GetAllAsync();

                var reservationResponse = new List<ReservationResponse>();

                foreach (var reservation in reservations)
                {
                    var reservationResponseNew = new ReservationResponse();

                    var bookTitle = await _reservationRepo.GetBookTitleById(reservation.BookId);
                    var reservationStatus = await _reservationRepo.GetReservationStatusNameById(reservation.ReservationStatusId);
                    var userName = await _reservationRepo.GetUserNameById(reservation.LocalUserId);

                    reservationResponseNew = _reservationWrapper.Bind(reservation, bookTitle, reservationStatus, userName );
                    reservationResponse.Add(reservationResponseNew);
                }

                return Ok(reservationResponse);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpGet GetAllBooksReservations nuluzo.");
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
        [HttpPost("Book/{bookId:int}/Create", Name = "CreateBookReservation")]
        [Authorize(Roles = "Administrator,Librarian")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ReservationResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<ReservationResponse>> CreateBookReservation(int bookId, string userName)
        {
            _logger.LogInformation($"{DateTime.Now} Executed CreateBookReservation.");

            try
            {
                
                if (bookId <= 0 || userName.Length <= 0 )
                {
                    return BadRequest();
                }


                var  bookReservation = await _reservationRepo.Reserve(bookId, userName);


                return CreatedAtRoute("CreateBookReservation", new { id = bookReservation.ReservationId }, bookReservation);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"{DateTime.Now} HttpPost CreateBookReservation nuluzo");
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
        [HttpPost("Book/{bookId:int}/Return", Name = "BookReturn")]
        [Authorize(Roles = "Administrator,Librarian")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ReservationResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<ReservationResponse>> BookReturn(int bookId, string userName)
        {
            _logger.LogInformation($"{DateTime.Now} Executed BookReturn.");

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
