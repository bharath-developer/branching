using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_or_odd___branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, reminder;
            Console.WriteLine("\n\n");
            Console.WriteLine("Check whether a number is even or odd :");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter an intger :");
            value = Convert.ToInt32(Console.ReadLine());
            reminder = value % 2;
            if (reminder == 0)
            {
                Console.WriteLine($"{value} is an even integer");
            }
            else
            {
                Console.WriteLine($"{value} is an odd integer");
            }

            Console.ReadLine();
        }
    }
}
