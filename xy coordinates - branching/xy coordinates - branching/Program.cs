using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xy_coordinates___branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("\n\n");
            Console.WriteLine("Find the quadrant in which the coordinate point lies :");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the value of X coordinate :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Y coordinate :");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordination point {x} {y} lies in the first quandrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The Coordinate point {x} {y} lies in the second quandrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The Coordinate point {x} {y} lies in the third quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point {x} {y} lies in the fourth quadrant");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"the coordinate point {x} {y} lies at the origin");
            }
            Console.ReadLine();
        }
    }
}
