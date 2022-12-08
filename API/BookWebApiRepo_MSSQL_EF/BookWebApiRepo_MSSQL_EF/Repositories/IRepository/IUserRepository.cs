using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;

namespace BookWebApiRepo_MSSQL_EF.Repositories.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        LocalUser Register(RegistrationRequest registrationRequest);
    }
}
