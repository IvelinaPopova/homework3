using System;

class Joro
{
    static void Main()
    {
        Console.WriteLine("Enter number of numbers:");
        int n = int.Parse(Console.ReadLine());

        while 



        Console.WriteLine("Enter number of Holidays: ");
        int hol = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of Weekends spent in the Hometown: ");
        int week = int.Parse(Console.ReadLine());

        int answer = 1;
        int check = 1;

        if (year > check)
        {
            answer = 2 * (52 - week) / 3 + hol / 2;
            Console.WriteLine(answer);
        }

        else
        {
            answer = 2 * (52 - week) / 3 + hol / 2 + 3;
            Console.WriteLine(answer);
        }

    }
}
