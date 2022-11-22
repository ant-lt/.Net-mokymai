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

        [HttpGet]
        public ActionResult<List<GetBookDto>> Get()
        {
            return Ok(_bookManager.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<GetBookDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("filter")]
        public ActionResult<List<GetBookDto>> Filter(FilterBookRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpPost()]
        public IActionResult Post(CreateBookDto req)
        {
            throw new NotImplementedException();
        }

        [HttpPut()]
        public IActionResult Put(UpdateBookDto req)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
