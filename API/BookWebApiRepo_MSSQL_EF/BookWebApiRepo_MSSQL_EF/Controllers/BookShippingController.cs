using BookWebApiRepo_MSSQL_EF.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApiRepo_MSSQL_EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookShippingController : ControllerBase
    {
        private readonly IShippingApiProxyService _service;
        private readonly ILogger<BookShippingController> _logger;

        public BookShippingController( IShippingApiProxyService service, ILogger<BookShippingController> logger)
        {
            _service = service;
            _logger= logger;
        }


        [HttpGet("GetShippingCosts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult<double>> GetShippingCosts([FromQuery] string city)
        {
            try
            {
                var deliveryCoordinates = await _service.GetCityLocation(city);
                if (deliveryCoordinates == "")
                {
                    _logger.LogInformation("City ({city}) entered by user not found!", city);
                    return NotFound();
                }

                var distanceInKm = await _service.GetDistanceFromCoordinates(deliveryCoordinates);


                return Ok(distanceInKm);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ivyko kazkas labai baisaus");
                return StatusCode(StatusCodes.Status500InternalServerError);               
            }

        }

    }
}
