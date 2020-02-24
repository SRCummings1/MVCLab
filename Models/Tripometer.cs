using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab.Models
{
    public class Tripometer
    {
        public double MPG { get; set; }
        public double Gallons { get; set; }
        public double Trip { get; set; }
        public double Range 
        {
            get {return MPG* Gallons; }
        }
    }
}
