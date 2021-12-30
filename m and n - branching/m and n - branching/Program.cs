using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_and_n___branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("\n\n");
            Console.WriteLine("Display the value of n is 1,0 and -1 for the value of er m:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the value of M :");
            m = Convert.ToInt32(Console.ReadLine());
            if (m != 0)
            {
                if (m > 0)
                {
                    n = 1;
                }
                else
                {
                    n = -1;
                }
            }
            else
            {
                n = 0;
            }
            Console.WriteLine($"The value of m = {m}");
            Console.WriteLine($"The value of n = {n}");
            Console.ReadLine();
        }
    }
}
