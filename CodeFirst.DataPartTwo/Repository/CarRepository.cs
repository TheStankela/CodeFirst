using CodeFirst.DataPartTwo.Interface;
using CodeFirst.DataPartTwo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DataPartTwo.Repository
{
    public class CarRepository : ICarRepository
	{
		public CarContext _carContext;
		public CarRepository(CarContext carContext)
		{
			_carContext = carContext;
		}

		public List<Car> GetAllCars()
		{
			return _carContext.Cars.Include(c => c.Engine).ToList();
		}

	}
}
