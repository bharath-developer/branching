int choice, r, l, w, b, h;
double area = 0;
Console.WriteLine("\n\n");
Console.WriteLine("A menu driven program to compute the area of various geometrical shape :");
Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine("\n\n");
Console.WriteLine("Enter 1 for area of circle :");
Console.WriteLine("Enter 2 for area of rectangle :");
Console.WriteLine("Enter 3 for area of triangle :");
Console.WriteLine("Enter your choice :");
choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
  case 1:
    Console.WriteLine($"Enter radius of the circle :");
    r = Convert.ToInt32(Console.ReadLine());
    area = 3.14 * r * r;
    Console.WriteLine($"The area is {area}");
    break;
  case 2:
    Console.WriteLine($"Enter length of the rectangle :");
    l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter width of the rectangle :");
    w = Convert.ToInt32(Console.ReadLine());
    area = l * w;
    Console.WriteLine($"The area is {area}");
    break;
  case 3:
    Console.WriteLine($"Enter base of the triangle :");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter height of the triangle :");
    h = Convert.ToInt32(Console.ReadLine());
    area = 5 * b * h;
    Console.WriteLine($"The area is {area}");
    break;
}
Console.ReadLine();