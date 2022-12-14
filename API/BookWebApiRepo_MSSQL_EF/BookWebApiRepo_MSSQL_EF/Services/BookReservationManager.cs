using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;

namespace BookWebApiRepo_MSSQL_EF.Services
{
    public class BookReservationManager : IBookReservationManager
    {
        private readonly IBookWrapper _wrapper;
        private readonly IReservationRepository _reservationRepo;

        public BookReservationManager(IReservationRepository reservationRepository, IBookWrapper bookWrapper)
        {
            _reservationRepo= reservationRepository;
            _wrapper = bookWrapper;
        }


        public ReservationResponse? Create(ReservationRequest book)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ReservationResponse>> GetAll()
        {
            var reservations = await _reservationRepo.GetAllAsync();

            var reservationResponse = new List<ReservationResponse>(); 

            foreach (var reservation in reservations)
            {
                var reservationResponseNew = new ReservationResponse();

                reservationResponseNew.ReservationId = reservation.Id;
                reservationResponseNew.ReservationDate = reservation.ReservationDate;
                reservationResponseNew.BookTitle = await _reservationRepo.GetBookTitleById(reservation.BookId);                
                reservationResponseNew.ReservationStatus = await _reservationRepo.GetReservationStatusNameById(reservation.ReservationStatusId);
                reservationResponseNew.UserName = await _reservationRepo.GetUserNameById(reservation.LocalUserId);

                
                reservationResponse.Add(reservationResponseNew);
            }



            return reservationResponse;
        }

        public ReservationResponse? Return(ReservationRequest book)
        {
            throw new NotImplementedException();
        }
    }
}
