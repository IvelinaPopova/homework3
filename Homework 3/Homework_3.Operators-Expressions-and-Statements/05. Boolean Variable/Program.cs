using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int ostatak = (number/100)%10;

        Console.WriteLine ( ostatak==7 ? "True" : "False");
    }
}
