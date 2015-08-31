using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int LeftSum = 0;
        int RightSum = 0;

        for(int i=0;i<2*n;i++)
        {
            int m = int.Parse(Console.ReadLine());
            if(i<n)
            {
                LeftSum += m;
            }
            if(i>=n)
            {
                RightSum += m;
            }
        }
        if(LeftSum==RightSum)
        {
            Console.WriteLine("Yes, sum={0}",LeftSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(LeftSum-RightSum));
        }
    }
}
