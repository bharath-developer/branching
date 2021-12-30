using System;

namespace profitAndLoss___branching
{
  class Program
  {
    static void Main(string[] args)
    {
      int value1, value2, result;
      Console.WriteLine("\n\n");
      Console.WriteLine("Calculate profit and loss on a transaction :");
      Console.WriteLine("--------------------------------------------");
      Console.WriteLine("\n\n");
      Console.WriteLine("Enter the first transaction :");
      Console.WriteLine("\n");
      value1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the second transaction :");
      Console.WriteLine("\n");
      value2 = Convert.ToInt32(Console.ReadLine());
      result = value1 - value2;
      if (result <= 0)
      {
        Console.WriteLine($"You can book your loss amount : {result}");
      }
      else
      {
        Console.WriteLine($"You can book your profit amount : {result}");
      }
    }
  }
}
