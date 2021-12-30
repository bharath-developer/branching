using System;

namespace gradeEqualent___branching
{
  class Program
  {
    static void Main(string[] args)
    {
      char value;
      Console.WriteLine("\n\n");
      Console.WriteLine("Enter a grade and display the equivalent description :");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("\n\n");
      Console.WriteLine("Enter a grade :");
      Console.WriteLine("\n");
      value = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
      switch (value)
      {
        case 'E':
          Console.WriteLine("Excellent");
          break;
        case 'V':
          Console.WriteLine("Very Good");
          break;
        case 'G':
          Console.WriteLine("Good");
          break;
        case 'A':
          Console.WriteLine("Average");
          break;
        case 'F':
          Console.WriteLine("Fail");
          break;
        default:
          Console.WriteLine("Please Enter a valid grade");
          break;
      }
      Console.ReadLine();
    }
  }
}
