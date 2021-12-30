using System;

namespace electricityBill___branching
{
  class Program
  {
    static void Main(string[] args)
    {
      int customerId, unit, netamount;
      double amount, total, surcharge = 0;
      string name;
      Console.WriteLine("\n\n");
      Console.WriteLine("Electricity bill generator :");
      Console.WriteLine("\n");
      Console.WriteLine("Enter the customer Id : \n");
      customerId = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter name of the customer : \n");
      name = Console.ReadLine();
      Console.WriteLine("Enter the unit consumed : \n");
      unit = Convert.ToInt32(Console.ReadLine());
      if (unit <= 199)
        amount = 1.20;
      else if (unit >= 200 && unit <= 399)
        amount = 1.50;
      else if (unit <= 400 && unit >= 599)
        amount = 1.80;
      else
        amount = 2.00;
      total = unit * amount;
      if (total > 400)
        surcharge = total * 15 / 100;
      total = surcharge + total;
      if (total < 100)
        netamount = 100;
      Console.WriteLine($"Total amount {total} for unit consumed {unit}");
      Console.ReadLine();
    }
  }
}
