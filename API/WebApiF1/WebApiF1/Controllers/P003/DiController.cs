using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiF1.Services;

namespace WebApiF1.Controllers.P003
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiController : Controller
    {
        private readonly IMyOperationTransient _operationTransient;
        private readonly IMyOperationScoped _operationScoped;
        private readonly IMyOperationSingleton _operationSingleton;

        public DiController(IMyOperationTransient operationTransient,
            IMyOperationScoped operationScoped,
            IMyOperationSingleton operationSingleton)
        {
            _operationTransient = operationTransient;
            _operationScoped = operationScoped;
            _operationSingleton = operationSingleton;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Transient = _operationTransient.GetOperationId(),
                Scoped = _operationScoped.GetOperationId(),
                Singleton = _operationSingleton.GetOperationId()
            });
        }
    }
}
