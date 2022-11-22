using WebApiF1.Models;

namespace WebApiF1.Services
{
    public interface IBookWrapper
    {
        public GetBookDto Bind(Book book);
        public Book Bind(CreateBookDto book);
        public Book Bind(UpdateBookDto book);
    }
}
