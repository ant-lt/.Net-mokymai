using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;

namespace P04_EF_Applying_To_API.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<bool> IsUniqueUserAsync(string username);
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
        Task<LocalUser> RegisterAsync(RegistrationRequest registrationRequest);
        Task<bool> IsRegisteredAsync(int userId);
    }
}
