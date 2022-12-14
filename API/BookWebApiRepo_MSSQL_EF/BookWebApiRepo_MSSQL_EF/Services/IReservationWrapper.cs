using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Services
{
    public interface IReservationWrapper
    {
        public ReservationResponse Bind(Reservation reservation, string bookTitle, string reservationStatus, string userName);
    }
}
