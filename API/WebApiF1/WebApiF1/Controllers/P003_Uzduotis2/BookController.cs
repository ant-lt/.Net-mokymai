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
        public ActionResult<List<Book>> Get()
        {
            return Ok( _bookManager.Get());
        }
    
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            return Ok(_bookManager.Get(id));
        }

        /*
        [HttpGet("filter")]
        public ActionResult<List<GetBookDto>> Filter(FilterBookRequest req)
        {
            throw new NotImplementedException();
        }
        */

        [HttpPost()]
        public ActionResult Create(Book req)
        {

            return Ok(_bookManager.Add(req));
        }

        
        [HttpPut("{id}")]
        public ActionResult Update(int id, Book req)
        {
            _bookManager.UpdateBook(id, req);
            return Ok();
        }

        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            _bookManager.DeleteBook(id);
            return Ok();

        }
    

    }
}
