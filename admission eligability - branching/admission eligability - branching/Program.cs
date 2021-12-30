using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admission_eligability___branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int maths, physics, chemisrty;
            Console.WriteLine("\n\n");
            Console.WriteLine("Find the eligibility for admission :");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Eligibility Criteria :");
            Console.WriteLine("Marks in maths >=65 :");
            Console.WriteLine("and marks in physics  >=55 :");
            Console.WriteLine("and marks in chemisrty >=50 :");
            Console.WriteLine("and total in all three subjects >=180 ");
            Console.WriteLine("or total in maths and physics >=140 ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enter the marks obtained in physics :");
            physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in maths :");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in chemistry :");
            chemisrty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total marks of maths , physics and chemistry :{chemisrty + physics + maths}");
            Console.WriteLine($"Total marks of maths and physics : {physics + maths}");
            if (maths >= 65)
            {
                if (physics >= 55)
                {
                    if (chemisrty >= 50)
                    {
                        if ((maths + physics + chemisrty) >= 180 || (maths + physics) >= 140)
                        {
                            Console.WriteLine("The candidate is eligable for admision");
                        }
                        else
                        {
                            Console.WriteLine("The candidate is not eligable for admission");
                        }
                    }
                    else
                        Console.WriteLine("The candidate is not eligable for admission");
                }
                else
                {
                    Console.WriteLine("The canidate is not eligable");
                }
            }
            else
            {
                Console.WriteLine("The candidate is not eligable");
            }
            Console.ReadLine();
        }
    }
}
