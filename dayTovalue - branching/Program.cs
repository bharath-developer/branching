using System;

namespace dayTovalue___branching
{
  class Program
  {
    static void Main(string[] args)
    {
      int value;
      Console.WriteLine("\n\n");
      Console.WriteLine("Read any day number in integer and display day name in the word :");
      Console.WriteLine("-----------------------------------------------------------------");
      Console.WriteLine("\n\n");
      Console.WriteLine("Enter the day :");
      Console.WriteLine("\n");
      value = Convert.ToInt32(Console.ReadLine());
      switch (value)
      {
        case 1:
          Console.WriteLine("Sunday");
          break;
        case 2:
          Console.WriteLine("Monday");
          break;
        case 3:
          Console.WriteLine("Tuesday");
          break;
        case 4:
          Console.WriteLine("Wednesday");
          break;
        case 5:
          Console.WriteLine("Thursday");
          break;
        case 6:
          Console.WriteLine("Friday");
          break;
        case 7:
          Console.WriteLine("Saturday");
          break;
        default:
          Console.WriteLine("Enter a valid day in digit");
          break;
      }
    }
  }
}
