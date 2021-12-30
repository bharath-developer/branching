using System;

namespace month_to_display___branching
{
  class Program
  {
    static void Main(string[] args)
    {
      int month;
      Console.WriteLine("\n\n");
      Console.WriteLine("Read month number and display month name :");
      Console.WriteLine("------------------------------------------");
      Console.WriteLine("\n\n");
      Console.WriteLine("Enter Month No :");
      month = Convert.ToInt32(Console.ReadLine());
      switch (month)
      {
        case 1:
          Console.WriteLine("janauary");
          break;
        case 2:
          Console.WriteLine("february");

          break;
        case 3:
          Console.WriteLine("march");
          break;
        case 4:
          Console.WriteLine("april");
          break;
        case 5:
          Console.WriteLine("may");
          break;
        case 6:
          Console.WriteLine("june");
          break;
        case 7:
          Console.WriteLine("july");
          break;
        case 8:
          Console.WriteLine("august");
          break;
        case 9:
          Console.WriteLine("september");
          break;
        case 10:
          Console.WriteLine("october");
          break;
        case 11:
          Console.WriteLine("november");
          break;
        case 12:
          Console.WriteLine("december");
          break;
        default:
          Console.WriteLine("Invalid Month number. please try again...");
          break;
      }
      Console.ReadLine();
    }
  }
}
