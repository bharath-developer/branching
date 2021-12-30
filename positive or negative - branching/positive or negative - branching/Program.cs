using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_or_negative___branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("\n\n");
            Console.WriteLine("Check a number is positive or negative:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter an number :");
            value = Convert.ToInt32(Console.ReadLine());
            if (value >= 0)
            {
                Console.WriteLine($"{value} is a positive number");
            }
            else
            {
                Console.WriteLine($"{value} is a negative number");
            }
            Console.ReadLine();
        }
    }
}
