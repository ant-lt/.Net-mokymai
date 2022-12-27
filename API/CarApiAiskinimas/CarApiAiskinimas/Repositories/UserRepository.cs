using CarApiAiskinimas.Database;
using CarApiAiskinimas.Models;
using CarApiAiskinimas.Services;

namespace CarApiAiskinimas.Repositories
{
    public interface IUserRepository
    {
        int Register(LocalUser user);
        bool TryLogin(string userName, string password, out LocalUser? user);
    }

    public class UserRepository : IUserRepository
    {
        private readonly CarContext _context;
        private readonly IUserService _userService;

        public UserRepository(CarContext context,
            IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public virtual bool TryLogin(string userName, string password, out LocalUser? user)
        {
            _userService.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            user = _context.Users.FirstOrDefault(x => x.UserName == userName);
            if (user == null)
                return false;

            if (_userService.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return false;

            return true;
        }

        public int Register(LocalUser user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
    }
}
