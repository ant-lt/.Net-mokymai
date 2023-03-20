using CarApiAiskinimas.Database;
using CarApiAiskinimas.Models;

namespace CarApiAiskinimas.Repositories
{
    public interface IUserCarRepository
    {
        IEnumerable<Car> Get(int userId);
    }
    public class UserCarRepository : IUserCarRepository
    {
        private readonly CarContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserCarRepository(CarContext context,
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<Car> Get(int userId)
        {
            var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);

            //var id = _httpContextAccessor.HttpContext.Request.Query["personId"];


            var entities =
                from carUser in _context.CarUser.Where(x => x.LocalUserId == currentUserId)
                    //from car in _context.Cars.Where(c => c.Id == carUser.CarId).DefaultIfEmpty() //left join
                join car in _context.Cars on carUser.CarId equals car.Id //inner join
                where carUser.LocalUserId == userId
                select car;

            //var entities1 = _context.CarUser
            //                        .Where(x => x.LocalUserId == userId)
            //                        .Join(_context.Cars,
            //                        u => u.CarId,
            //                        c => c.Id,
            //                        (u, c) => c);


            return entities;
        }
    }


}