using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy
{
    class Triangle : TwoDimensionalShape
    {
        public double Base { get; } // will get the base from the user 
        public double Height { get; }
        public override string Name => "Triangle";
        public override double Area => 0.5 * Base * Height;

        public Triangle (double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }
    }
}
