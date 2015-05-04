using System;

class StringsAndObjects
{
    static void Main()
    {
        Console.WriteLine("Enter a  four-digit number:");
        int number = int.Parse(Console.ReadLine());

        int a = number / 1000;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;

        int sum = a + b + c + d;
        Console.WriteLine(sum);

        string aa = a.ToString();
        string bb = b.ToString();
        string cc = c.ToString();
        string dd = d.ToString();

        
        Console.WriteLine("{0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}
