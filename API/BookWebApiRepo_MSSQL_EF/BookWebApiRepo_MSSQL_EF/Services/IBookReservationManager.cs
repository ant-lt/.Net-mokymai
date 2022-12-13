using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;

namespace BookWebApiRepo_MSSQL_EF.Services
{
    public interface IBookReservationManager
    {
        public Task<List<ReservationResponse>> GetAll();
        public ReservationResponse? Create(ReservationRequest book);
        public ReservationResponse? Return(ReservationRequest book);
    }
}
