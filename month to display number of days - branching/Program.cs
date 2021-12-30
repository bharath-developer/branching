using System;

namespace month_to_display_number_of_days___branching
{
  class Program
  {
    static void Main(string[] args)
    {
      int month;
      Console.WriteLine("\n\n");
      Console.WriteLine("Read month number and display number of days for the month :");
      Console.WriteLine("------------------------------------------------------------");
      Console.WriteLine("\n\n");
      Console.WriteLine("Enter Month Number :");
      month = Convert.ToInt32(Console.ReadLine());
      switch (month)
      {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
          Console.WriteLine("Month have 31 days");
          break;
        case 2:
          Console.WriteLine("The second month is a feb and have 28 days.In leap year the feb month have 29 days.");
          break;
        case 4:
        case 6:
        case 9:
        case 11:
          Console.WriteLine("Month have 30 days");
          break;
        default:
          Console.WriteLine("Invalid month number please try again.");
          break;
      }
      Console.ReadLine();
    }
  }
}
