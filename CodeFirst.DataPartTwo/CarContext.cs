using CodeFirst.DataPartTwo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DataPartTwo
{
	public class CarContext : DbContext
	{
		public DbSet<Car> Cars { get; set; }
		public DbSet<Engine> Engines { get; set; }
		public DbSet<EngineType> EngineTypes { get; set; }
		public CarContext(DbContextOptions options) : base(options)
		{

		}
	}
}
