using System;

class PointCoordinates
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinate \"x\" of a point: ");
        double corX = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate \"y\" of a point: ");
        double corY = double.Parse(Console.ReadLine());

        if (corY < 1)
        {
             Console.WriteLine("This point is not in the wanted area");
        }            
        else
        {
            Console.WriteLine((corX-1)*(corX-1) + (corY-1)*(corY-1)<=2.25? "This point is in the wanted area": "This point is not in the wanted area");
        }

    }
}
