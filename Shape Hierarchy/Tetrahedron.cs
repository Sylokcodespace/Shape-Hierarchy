using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy
{
    class Tetrahedron : ThreeDimensionalShape
    {
        public double Edge { get; }
        public override double Area => Math.Sqrt(3) * Edge * Edge;
        public override string Name => "Tetrahedron";
        public override double Volume => (Math.Pow(Edge, 3) / (6 * Math.Sqrt(2))); // for calculating the a regular tetrahedron
        
        public Tetrahedron(double edges)
        {
            Edge = edges;
        }

    }

   
}
