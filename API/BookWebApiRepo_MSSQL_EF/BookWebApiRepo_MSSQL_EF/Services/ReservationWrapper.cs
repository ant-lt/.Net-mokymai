using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;

namespace BookWebApiRepo_MSSQL_EF.Services
{
    public class ReservationWrapper : IReservationWrapper
    {
        public ReservationResponse Bind(Reservation reservation, string bookTitle, string reservationStatus, string userName)
        {
            return new ReservationResponse
            {
                ReservationId = reservation.Id,
                ReservationDate = reservation.ReservationDate,
                BookTitle = bookTitle,
                ReservationStatus = reservationStatus,
                UserName = userName
            };
        }
    }
}
