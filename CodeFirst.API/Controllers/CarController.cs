using CodeFirst.DataPartTwo.Interface;
using CodeFirst.DataPartTwo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarController : ControllerBase
	{
		private readonly ICarRepository _carRepository;

		public CarController(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}
		[HttpGet]
		public IActionResult GetAllCars()
		{
			var result = _carRepository.GetAllCars();
			if(result.Count == 0)
				return NotFound();

			return Ok(result);
		}
		[HttpPost]
		public IActionResult CreateCar([FromBody] Car car, Engine engine, EngineType engineType)
		{

		}
    }
}
