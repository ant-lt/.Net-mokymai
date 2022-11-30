using System.Collections.Generic;
using WebApiF1.Database;
using WebApiF1.Models;

namespace WebApiF1.Services
{
    public class BookManager: IBookManager
    {
//        private readonly IBookSet _context;
        private readonly IBookWrapper _wrapper;
        private readonly BookDataContext _bookDataContext;

        public BookManager(BookDataContext bookDataContext, IBookWrapper bookWrapper)
        {
            _bookDataContext = bookDataContext;
            _wrapper = bookWrapper;
        }

        /*
        public BookManager(IBookSet bookSet, IBookWrapper bookWrapper) { 
            _context = bookSet;
            _wrapper = bookWrapper;
        }
        */

        public List<GetBookDto> Get()
        {
            var books =  _bookDataContext.Books.ToList();

            List<GetBookDto> _bookDto = new List<GetBookDto>();

            foreach (var book in books)
            {
                _bookDto.Add(_wrapper.Bind(book));
            }
            
            return _bookDto;
        }

        public GetBookDto? Get(int id)
        {
            var book = _bookDataContext.Books.FirstOrDefault(x => x.Id == id);
            if  (book == null)
            {
                return null;
            }
            return _wrapper.Bind(book);
        }


        public bool Exist (int id)
        {
            return false;
        }


        public List<GetBookDto>? Filter(FilterBookRequest filter) {

            var books = _bookDataContext.Books.Where(e => e.Title == filter.Pavadinimas && e.Author == filter.Autorius).ToList();

            if (books.Count == 0)
            {
                return null;
            }

            List <GetBookDto> _bookDto = new List<GetBookDto>();
            foreach (var book in books)
            {
                _bookDto.Add(_wrapper.Bind(book));
            }
            return _bookDto;
        }


        public Book? Add(CreateBookDto bookAdd)
        {

             Book _book = _wrapper.Bind(bookAdd);

            if (_bookDataContext.Books.Add(_book) != null)
            {
                _bookDataContext.SaveChanges();
                return _book;
            }
            else return null;
        }


        public Book? UpdateBook(int id, UpdateBookDto bookUpdate)
        {
            var book = _bookDataContext.Books.Find(id);
            Console.WriteLine($"Update Book id={id} from bookUpdate=>{bookUpdate.Id} ");
            if (book != null)
            {
                Book _bookUpdate = _wrapper.Bind(bookUpdate);

                //_bookUpdate.Id = id;
                book.Author = _bookUpdate.Author;
                book.Title = _bookUpdate.Title;
                book.Years = _bookUpdate.Years;
                book.CoverType = _bookUpdate.CoverType;

                _bookDataContext.Update(book);
                _bookDataContext.SaveChanges();
                return book;
            }
            else return null;
        }


        public Book? DeleteBook (int id)
        {
            var book = _bookDataContext.Books.Find(id);
            if (book != null)
            {

                _bookDataContext.Remove(book);
                _bookDataContext.SaveChanges();
                return book;
            }
            else return null;             
        }
    }
}
