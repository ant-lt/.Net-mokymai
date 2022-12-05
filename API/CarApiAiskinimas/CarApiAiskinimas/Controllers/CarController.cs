using CarApiAiskinimas.Models;
using CarApiAiskinimas.Models.Dto;
using CarApiAiskinimas.Repositories;
using CarApiAiskinimas.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

/*
aplikacija automobiliu registas
issukiai:
1. kazkas kas viska kontroliuoja. Tai bus Controller
2. mums reikia kuo greiciau atiduoti darbus front-end. Ty. reikalinga Swagger dokumentacija ir sukurti DTO kontrakta
3. nuspresti kokia yra biznio logika. Biznio modelius ir servisus
4. Duomenu baze. EF, migracijos
5. programa atvira modifikacijoms. DI
6. programa turi buti gera ir testuojama. Repository
7. programa turi tureti diagnostika produkcineje erdveje. Logger
8. Validacijos. Attribute validations
9. Autentifikacija. JWT 
10. Automatinis testavimas. Unit testai
*/

namespace CarApiAiskinimas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {

        private readonly ILogger<CarController> _logger;
        private readonly IRepository<Car> _repository;
        private readonly ICarAdapter _adapter;

        public CarController(ILogger<CarController> logger,
            IRepository<Car> repository,
            ICarAdapter adapter)
        {
            _logger = logger;
            _repository = repository;
            _adapter = adapter;
        }

        /// <summary>
        /// Gaunamas duomenu bazeje esanciu automobiliu sarasas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResult>))]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get()
        {
            var entities = _repository.All();
            var model = entities.Select(x => _adapter.Bind(x));

            return Ok(model);
        }

        /// <summary>
        /// Gaunamas duomenu bazeje esanciu automobiliu sarasas
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetCarResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get(int id)
        {
            if (!_repository.Exist(id))
                return NotFound();

            var entity = _repository.Get(id);
            var model = _adapter.Bind(entity);

            return Ok(model);
        }

        /// <summary>
        /// Filtras duomenu bazeje esanciu automobiliu sarasas
        /// </summary>
        /// <returns></returns>
        [HttpGet("filter")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetCarResult))]        
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get([FromQuery]FilterCarRequest req)
        {
            IEnumerable<Car> entities = _repository.All().ToList();

            if (req.Mark != null)
                entities = entities.Where(x => x.Mark == req.Mark);

            if (req.Model != null)
                entities = entities.Where(x => x.Model == req.Model);

            if (req.GearBox != null)
                entities = entities.Where(x => x.GearBox == (ECarGearBox)Enum.Parse(typeof(ECarGearBox), req.GearBox));

            if (req.Fuel != null)
                entities = entities.Where(x => x.Fuel == (ECarFuel)Enum.Parse(typeof(ECarFuel), req.Fuel));

            var model = entities?.Select(x => _adapter.Bind(x));

            return Ok(model);
        }

        /// <summary>
        /// Irasomas automobilis i duomenu baze
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Post(PostCarRequest req)
        {

            return Created("PostCar", new { Id = 0 /*TODO*/});
        }


        /// <summary>
        /// Modifikuojamas automobilis duomenu bazeje
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Put(PutCarRequest req)
        {

            return NoContent();
        }

        /// <summary>
        /// Trinamas automobilis is duomenu bazes
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {

            return NoContent();
        }
    }
}