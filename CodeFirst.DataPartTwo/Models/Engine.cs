using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DataPartTwo.Models
{
	public class Engine
	{
        public int Id { get; set; }
        public string Brand { get; set; }
        public int SerialNumber { get; set; }
        public EngineType EngineType { get; set; }
        public int EngineTypeId { get; set; }
    }
}
