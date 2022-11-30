using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P02_REST_points_Uzduotis1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbysportController : ControllerBase
    {
        [HttpGet("GetSports")]
        public IEnumerable<FoodDTO> GetAllFood()
        {
            var foods = FoodStore.foodList;

            return foods;
        }
    }
}
