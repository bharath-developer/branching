using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equals_branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2;
            Console.WriteLine("\n\n");
            Console.WriteLine("Check whether two integers are equal or not :");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Input First Number:");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second Number:");
            value2 = Convert.ToInt32(Console.ReadLine());
            
            if(value1 == value2)
            {
                Console.WriteLine($"{value1} and {value2} are equal");
            }
            else
            {
                Console.WriteLine($"{value1} and  {value2} are not equal");
            }
            Console.ReadLine();
        }
    }
}
