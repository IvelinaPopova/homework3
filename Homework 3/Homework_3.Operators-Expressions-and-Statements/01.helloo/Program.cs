using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        long number = long.Parse(Console.ReadLine());
        long a = number % 2;
                                  
            Console.WriteLine (a==1? "True" : "False");        
        
    }
}

