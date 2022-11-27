using WebApiF1.Database;
using WebApiF1.Models;

namespace WebApiF1.Services
{
    public class BookManager: IBookManager
    {
//        private readonly IBookSet _context;
//        private readonly IBookWrapper _wrapper;
        private readonly BookDataContext _bookDataContext;

        public BookManager(BookDataContext bookDataContext)
        {
            _bookDataContext = bookDataContext;
        }

        /*
        public BookManager(IBookSet bookSet, IBookWrapper bookWrapper) { 
            _context = bookSet;
            _wrapper = bookWrapper;
        }
        */

        public List<Book> Get()
        {
            var books =  _bookDataContext.Books.ToList();
            
            return books;
        }

        public Book? Get(int id)
        {
            var book = _bookDataContext.Books.FirstOrDefault(x => x.Id == id);
            if  (book == null)
            {
                return null;
            }
            return book;
        }

/*        public GetBookDto Get(int id) {
            return new GetBookDto();
        }
*/
        public bool Exist (int id)
        {
            return false;
        }

        public List<GetBookDto>? Filter( Dictionary<string, string> filter) {

            return null;
        }

        public int Add(Book bookAdd)
        {
            var book = _bookDataContext.Books.Add(bookAdd);

            _bookDataContext.SaveChanges();
            return 0;
        }


        public void UpdateBook(int id, Book bookUpdate)
        {
            var book = _bookDataContext.Books.Find(id);
            if (book != null)
            {
                book.Author = bookUpdate.Author;
                book.Title = bookUpdate.Title;
                book.Years = bookUpdate.Years;
                book.CoverType = bookUpdate.CoverType;

                _bookDataContext.Update(book);
                _bookDataContext.SaveChanges();
            }

        }


        public void DeleteBook (int id)
        {
            var book = _bookDataContext.Books.Find(id);
            if (book != null)
            {

                _bookDataContext.Remove(book);
                _bookDataContext.SaveChanges();
            }
        }
    }
}
