using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiF1.Models.ApiModels;
using WebApiF1.Services;

namespace WebApiF1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakeApiController : ControllerBase
    {
        private readonly IFakeApiProxyService _service;
        private readonly ILogger<FakeApiController> _logger;

        public FakeApiController(IFakeApiProxyService service,
            ILogger<FakeApiController> logger)
        {
            _service = service;
            _logger = logger;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BookApiResult>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var res = await _service.GetBooks();
                return Ok(res);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ivyko kazkas labai baisaus");
                throw;
            }

        }
    }
}
