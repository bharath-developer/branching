using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting_eligability___branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("\n\n");
            Console.WriteLine("Detemine a specific age is eligible for casting the vote :");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter Your Age :");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote");
            }
            else
            {
                Console.WriteLine("Sorry, You are not eligible for casting your vote");
                Console.WriteLine($"You would be able to casting your vote after {18 - age} year.");
            }
            Console.ReadLine();
        }
    }
}
