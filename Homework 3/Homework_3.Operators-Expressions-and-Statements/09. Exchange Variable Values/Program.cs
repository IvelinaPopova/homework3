using System;

class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("Enter the firs side of a trapezoid: ");
        double firstBase = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second side of a trapezoid: ");
        double secondBase = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of a trapezoid: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of the trapezoid is:" + ((firstBase + secondBase) * height / 2));
    }
}