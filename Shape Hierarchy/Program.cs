namespace Shape_Hierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base length for Triangle");
            double triangleBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height for Triangle");
            double triangleHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Edges for a Tetrahedron");
            double tertaEdge = double.Parse(Console.ReadLine());

            Shape[] shapes =
            {
                new Triangle(triangleBase, triangleHeight),
                new Tetrahedron(tertaEdge)
            };

            foreach (Shape shape in shapes) 
            {
                Console.WriteLine($"Shape {shape.Name}");
                if (shape is TwoDimensionalShape twoDShape)
                {
                    Console.WriteLine($"Area: {twoDShape.Area:F2}\n");
                }
                else if (shape is ThreeDimensionalShape threeDShape)
                {
                    Console.WriteLine($"Surface Area: {threeDShape.Area}\n");
                    Console.WriteLine($"Volume: {threeDShape.Volume}\n");
                }
            }
        }
    }
}
