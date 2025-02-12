using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy
{
    abstract class TwoDimensionalShape : Shape
    {
        public abstract double Area { get; }
    }
}
