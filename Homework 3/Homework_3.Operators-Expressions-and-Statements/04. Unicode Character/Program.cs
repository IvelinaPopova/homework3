
using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter the height of a rectangle:");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of a rectangle:");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter:" + (height+width)*2);
        Console.WriteLine("Area:" + (height*width));

    }
}

