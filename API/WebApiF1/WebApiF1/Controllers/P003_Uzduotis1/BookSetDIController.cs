using Microsoft.AspNetCore.Mvc;
using WebApiF1.Models;
using WebApiF1.Services;

namespace WebApiF1.Controllers.P003_Uzduotis1
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookSetDIController : Controller
    {
        private readonly IBookSet _mySet;

        public BookSetDIController(IBookSet mySet)
        {
            _mySet = mySet ?? throw new ArgumentNullException(nameof(mySet));
        }

        [HttpGet("all")]
        public List<Book> GetAllBooks()
        {
            return _mySet.Books;
        }

        [HttpGet("{id}")]
        public Book? GetBookById(int id)
        {
            return _mySet.Books.Where(b => b.Id == id).FirstOrDefault();
        }

    }
}
