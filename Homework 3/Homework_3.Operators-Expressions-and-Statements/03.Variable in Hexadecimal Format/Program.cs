using System;

class Divide
{
    static void Main()
    {
        Console.WriteLine("Enter the weight of a man on the earth:");
        long number = long.Parse(Console.ReadLine());

        long a = number % 5;
        long b = number % 7;

        if (a==0)
            if (b==0)
        {
            Console.WriteLine("True");
        }
             else 
                {
                  Console.WriteLine("False");
                }
        else
        {
            Console.WriteLine("False");
        }


    }
}
