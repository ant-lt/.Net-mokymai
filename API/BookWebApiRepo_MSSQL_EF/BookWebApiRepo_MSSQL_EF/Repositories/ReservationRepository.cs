using BookWebApiRepo_MSSQL_EF.Data;
using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
using BookWebApiRepo_MSSQL_EF.Services;
using System.Net;

namespace BookWebApiRepo_MSSQL_EF.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        private readonly BookContext _db;

        public ReservationRepository(BookContext db) : base(db)
        {
            _db = db;
        }

        public async Task<string> GetBookTitleById(int bookId)
        {
            var book = await _db.Books.FindAsync( bookId );
            return book.Title;
        }

        public async Task<string> GetReservationStatusNameById(int reservationStatusId)
        {
            var reservationStatus = await _db.ReservationStatus.FindAsync(reservationStatusId);
            return reservationStatus.Status;
        }

        public async Task<string> GetUserNameById(int userId)
        {
            var user = await _db.LocalUsers.FindAsync(userId);
            return user.Username;
        }

        public async Task<int> GetUserReservedBooksCount(string userName)
        {
            int userId = _db.LocalUsers.FirstOrDefault(x => x.Username == userName).Id;
            int ActiveReservationStatusId =  _db.ReservationStatus.FirstOrDefault(x => x.Status == "Active").Id;

            int bookCount = 0;

            bookCount =  _db.Reservations.Where(x => x.LocalUserId == userId && x.ReservationStatusId == ActiveReservationStatusId).Count();
            return bookCount;
        }

        public async Task<bool> IsBookAvailableForReservation(int bookId)
        {
            var book = await _db.Books.FindAsync(bookId);

            if (book == null)
            {
                return false;
            }

            if (book.OwnedQty >0) 
            { 
                return true;
            }
            else 
                return false;

        }

        public async Task<ReservationResponse> Reserve(int bookId, string userName)
        {

            var book = await _db.Books.FindAsync(bookId);

            var reservation = new Reservation()
            {
                ReservationDate = DateTime.Now,
                BookId = bookId,
                LocalUserId = _db.LocalUsers.FirstOrDefault(x => x.Username == userName).Id,
                ReservationStatus = _db.ReservationStatus.FirstOrDefault(x => x.Status == "Active")
            };



            await CreateAsync(reservation);

            book.OwnedQty -= 1;

            _db.Books.Update(book);
            // await _db.SaveChangesAsync();

            await SaveAsync();

            var ReservationResponse = new ReservationResponse()
            {
                ReservationId = reservation.Id,
                ReservationDate = reservation.ReservationDate,
                UserName = userName,
                BookTitle = _db.Books.FirstOrDefault(x => x.Id == bookId).Title,
                ReservationStatus = "Active"
            };

            return ReservationResponse;
        }


        public async Task<ReservationResponse> Return(int bookId, string userName)
        {
            
            var localUserId = _db.LocalUsers.First(x => x.Username == userName).Id;
            var activeStatus = _db.ReservationStatus.First(x => x.Status == "Active");
            var reservation = _db.Reservations.First(x => x.BookId == bookId  && x.LocalUserId == localUserId && x.ReservationStatusId == activeStatus.Id);

            reservation.ReservationStatus = _db.ReservationStatus.FirstOrDefault(x => x.Status == "Returned");

        

            var reservationResponse = new ReservationResponse() 
            { 
                ReservationId = reservation.Id,
                ReservationDate = reservation.ReservationDate,
                UserName = userName,
                BookTitle = _db.Books.FirstOrDefault(x => x.Id == bookId).Title,
                ReservationStatus = "Returned"
            };

            _db.Reservations.Update(reservation);

     

            var createLoan = new Loan()
            {
                BookId= bookId,
                LocalUserId = localUserId,
                LoanDate = reservation.ReservationDate,
                ReturnedDate= DateTime.Now,
            };

            _db.Loans.Add(createLoan);


            var book = await _db.Books.FindAsync(bookId);
            book.OwnedQty += 1;

            _db.Books.Update(book);


            await SaveAsync();


            var _fineCalc = new FinesService();
            var fine = _fineCalc.CallculateFineOnReturn(createLoan);

            if (fine != null)
            {
                _db.Fines.Add(fine);
                await SaveAsync();
            }


            return reservationResponse;
        }
    }
}
