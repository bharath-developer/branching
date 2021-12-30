using System;

namespace calculator___branching
{
  class Program
  {
    public static void Main()
    {
      int number1, number2, option;
      Console.WriteLine("\n\n");
      Console.WriteLine("A menu driven program for a single calculator :");
      Console.WriteLine("-----------------------------------------------");
      Console.WriteLine("\n\n");
      Console.WriteLine("Enter the first integer :");
      number1 = Convert.ToInt32(
        Console.ReadLine()
      );
      Console.WriteLine("Enter the second integer");
      number2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("\n");
      Console.WriteLine("Here is the options");
      Console.WriteLine("\n\n");
      Console.Write("1 - Addition \n 2 - Subract \n 3 - Multiply \n 4 - Division \n 5 - Exit");
      Console.WriteLine("Enter your choice :");
      option = Convert.ToInt32(Console.ReadLine());
      switch (option)
      {
        case 1:
          Console.WriteLine($"The addition of {number1} and {number2} is : {number1 + number2}");
          break;
        case 2:
          Console.WriteLine($"The subract of {number1} and {number2} is : {number1 - number2}");
          break;
        case 3:
          Console.WriteLine($"The multiply of {number1} and {number2} is : {number1 * number2}");
          break;
        case 4:
          if (number2 == 0)
          {
            Console.WriteLine($"The second integer is zero.Divided by zero.");
          }
          Console.WriteLine($"The division of {number1} and {number2} is : {number1 / number2}");
          break;
        case 5:
          Console.Write("Input correct option");
          break;
      }
      Console.ReadLine();
    }
  }
}
