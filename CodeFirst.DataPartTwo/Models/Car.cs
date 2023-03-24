using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DataPartTwo.Models
{
	public class Car
	{
        //color, year, chassis number, brand, model
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string ChassisNumber { get; set; } 
        public Engine Engine { get; set; }
        public int EngineId { get; set; }

    }
}
