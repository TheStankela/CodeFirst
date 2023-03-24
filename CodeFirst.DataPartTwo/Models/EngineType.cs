using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DataPartTwo.Models
{
	public class EngineType
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public string Name { get; set; }
		public List<Engine> Engines { get; set; }
	}
}
