using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());        
        int nRightP = n >> 3;
        int bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}