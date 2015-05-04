using System;

class ModifyaBitatGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());


        int nAFirst = n >> 3;
        int nALast = nAFirst << 3;

        int secTripleA = n >> 24;
        int secTripleB = secTripleA << 29;
        int secTripleC = secTripleB >> 29;
        int nConv = nALast ^ secTripleC;

       

        int firstTripleA = n << 29;
        int firstTripleB = firstTripleA >> 5;       
        

        int secTripleHelp = secTripleB >> 5;
        int nBFirst = nConv ^ secTripleHelp;
        int nConvLast = nBFirst ^ firstTripleB;

        Convert.ToString(nConvLast, 2);
        Console.WriteLine(nConvLast);



    }
}

