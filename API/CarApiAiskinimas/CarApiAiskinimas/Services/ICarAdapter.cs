using CarApiAiskinimas.Models.Dto;
using CarApiAiskinimas.Models;

namespace CarApiAiskinimas.Services
{
    public interface ICarAdapter
    {
        GetCarResult Bind(Car car);
    }
    
}
