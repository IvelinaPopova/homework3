using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the wanted index:");
        int p = int.Parse(Console.ReadLine());
        
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}