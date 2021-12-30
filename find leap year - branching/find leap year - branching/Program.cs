using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_leap_year___branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int cheYear;
            Console.WriteLine("\n\n");
            Console.WriteLine("Check whether a given year is leap year or not :");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Input an year :");
            cheYear = Convert.ToInt32(Console.ReadLine());
            if (cheYear % 400 == 0)
                Console.WriteLine($"{cheYear} is a leap year.");
            else if (cheYear % 100 == 0)
                Console.WriteLine($"{cheYear} is not a leap year");
            else if (cheYear % 4 == 0)
                Console.WriteLine($"{cheYear} is a leap year");
            else
                Console.WriteLine($"{cheYear} is not a leap year");
            Console.ReadLine();
        }
    }
}
