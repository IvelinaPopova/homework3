using System;

class ModifyaBitatGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the wanted index:");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of the index:");
        int v = int.Parse(Console.ReadLine());

        if (v==0)
        {
            int nRight = n >> p;
            int bitFirst = nRight & 1;

            if (bitFirst == 0)
            {
                Console.WriteLine(n);
            }                
            else 
            {
                int nHelp = 1<<p;
                Console.WriteLine(n ^ nHelp);
            }
        }

        else
        {
            int nRight = n >> p;
            int bitFirst = nRight & 1;

            if (bitFirst == 0)
            {
                int nHelp = 1 << p;
                Console.WriteLine(n | nHelp);
            }
            
            else
            {
                Console.WriteLine(n);
            }
        }

                
        

        
    }
}
