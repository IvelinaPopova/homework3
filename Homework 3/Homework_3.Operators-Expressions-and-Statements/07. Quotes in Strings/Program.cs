using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinate \"x\" of a point: ");
        double corX = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate \"y\" of a point: ");
        double corY = double.Parse(Console.ReadLine());

        Console.WriteLine((corX * corX + corY * corY) < 4 ? "This point is in a circle K({0,0},2)" : "This point is not in a circle K({0,0},2)");

    }   
}