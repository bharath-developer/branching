using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace height___branching
{
    class Program
    {
        static void Main(string[] args)
        {
            float personHeight;
            Console.WriteLine("\n\n");
            Console.WriteLine("Accept the height of a person in centemeter and categorize them :");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the height of the person (in centemeters) :");
            personHeight = (float)Convert.ToDouble(Console.ReadLine());
            if (personHeight < 150.0)
                Console.WriteLine("The person is dwarf");
            else if (personHeight >= 150.0 && personHeight <= 165.0)
                Console.WriteLine("The person is average heighted");
            else if (personHeight >= 165.0 && personHeight <= 195.0)
                Console.WriteLine("The person is taller");
            else
                Console.WriteLine("Abnormal height");

            Console.ReadLine();
       }
    }
}
