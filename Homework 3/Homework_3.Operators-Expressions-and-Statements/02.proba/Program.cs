using System;

class MoonWeight
{
    static void Main()
    {
        Console.WriteLine("Enter the weight of a man on the earth:");
        double weightEarth = double.Parse(Console.ReadLine());
        double weightMoon = 0.17 * weightEarth;
        Console.WriteLine(weightMoon);
    }
}


