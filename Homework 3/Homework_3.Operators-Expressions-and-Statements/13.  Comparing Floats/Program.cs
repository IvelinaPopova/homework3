using System;

class NullValuesArithmetic
{
    static void Main()
    {
        double a = 0.12345678d;
        double b = 0.12345679d;
        bool check = (a == b);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(check);
    }
}