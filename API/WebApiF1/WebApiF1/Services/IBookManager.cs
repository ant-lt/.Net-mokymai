using WebApiF1.Models;

namespace WebApiF1.Services
{
    public interface IBookManager
    {
        public List<Book> Get();
        public Book? Get(int id);
        public bool Exist(int id);
        public List<GetBookDto>? Filter(Dictionary<string, string> filter);
        public int Add(Book book);
        public void UpdateBook(int id, Book book);
        public void DeleteBook(int id);
    }
}