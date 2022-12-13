using BookWebApiRepo_MSSQL_EF.Data;
using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
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
            var ReservationStatus = await _db.ReservationStatus.FindAsync(reservationStatusId);
            return ReservationStatus.Status;
        }

        public async Task<ReservationResponse> Reserve(int bookId, string userName)
        {

            var reservation = new Reservation()
            {
                ReservationDate = DateTime.Now,
                BookId = bookId,
                LocalUserId = _db.LocalUsers.FirstOrDefault(x => x.Username == userName).Id,
                ReservationStatus = _db.ReservationStatus.FirstOrDefault(x => x.Status == "Active")
            };

            Create(reservation);            
            Save();

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

            //Save();

            var createLoan = new Loan()
            {
                BookId= bookId,
                LocalUserId = localUserId,
                LoanDate = reservation.ReservationDate,
                ReturnedDate= DateTime.Now,
            };

            await _db.Loans.AddAsync(createLoan);
            //await _db.SaveChangesAsync();
            Save();

            return reservationResponse;
        }
    }
}
