using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;

namespace BookWebApiRepo_MSSQL_EF.Repositories.IRepository
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<ReservationResponse> Reserve(int bookId, string userName);
        Task<ReservationResponse> Return(int bookId, string userName);
    }
}
