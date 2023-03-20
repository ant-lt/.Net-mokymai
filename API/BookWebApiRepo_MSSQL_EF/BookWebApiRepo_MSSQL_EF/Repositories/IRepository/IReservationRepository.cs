using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;

namespace BookWebApiRepo_MSSQL_EF.Repositories.IRepository
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<ReservationResponse> Reserve(int bookId, string userName);
        Task<ReservationResponse> Return(int bookId, string userName);
        Task<string> GetReservationStatusNameById(int reservationStatusId);
        Task<string> GetBookTitleById(int bookId);
        Task<string> GetUserNameById(int userId);
        Task<bool> IsBookAvailableForReservation(int bookId);
        Task<int> GetUserReservedBooksCount(string userName);
        Task<bool> IsUserHaveDebts(string userName);
    }
}
