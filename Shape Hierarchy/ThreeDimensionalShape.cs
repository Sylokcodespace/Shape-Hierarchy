using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy
{
    abstract class ThreeDimensionalShape : Shape
    {
        public abstract double Area { get; } // surface area
        public abstract double Volume { get; }
    }
}
