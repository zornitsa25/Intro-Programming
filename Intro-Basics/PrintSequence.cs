using System;

class PrintSequence
{
    static void Main(string[] args)
    {
        int sign = 1;
        int n = 11;
        for(int i=2;i<n;i++)
        {
            Console.Write("{0},",i*sign);
            sign = -sign;
        }
        Console.WriteLine("{0}", -n);
    }
}
