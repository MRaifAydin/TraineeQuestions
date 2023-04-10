using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SumsOfComplexRows
{
    public class SchoolDto
    {
        public string SchoolName { get; set; }
        public int TotalFloors { get; set; }
        public List<FloorDto> Floors { get; set; }
    }
}
