using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;

namespace BookWebApiRepo_MSSQL_EF.Repositories.IRepository
{
    public interface IUserRepository
    {
        Task<bool> IsUniqueUserAsync(string username);
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
        Task<LocalUser> RegisterAsync(RegistrationRequest registrationRequest);
    }
}
