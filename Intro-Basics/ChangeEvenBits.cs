using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeEvenBits
{
    class ChangeEvenBits
    {
        private static int CountBits(ushort num)
        {
            int sizeUshort = 16;
            int one = 1 << sizeUshort;
            int count = 0;

            for (int i = 1; i <= sizeUshort; i++)
            {
                bool bitTrue=Convert.ToBoolean((one>>i) & num);
                if (bitTrue)
                {
                    count = sizeUshort - i + 1;
                    break;
                }
            }
            return count;
        }

        private static int CountEvenZeros(ulong num,int size)
        {
            int len = 0;

            for(int i=0;i<size*2;i+=2)
            {
                bool isZero=Convert.ToBoolean((num>>i) & 1);
                if(!isZero)
                {
                    len++;
                }
            }
            return len;
        }

        private static void ChangeBits(ref ulong num,int size)
        {
            for(int i=0;i<size*2;i+=2)
            {
                num |= Convert.ToUInt32(1 << i);
            }
        }

        static void Main()
        {
            byte N = byte.Parse(Console.ReadLine());
            List<ushort> numbers = new List<ushort>();

            for (int i = 0; i < N; i++)
            {
                ushort m = ushort.Parse(Console.ReadLine());
                numbers.Add(m);
            }
            ulong L = ulong.Parse(Console.ReadLine());

            int allZeros = 0;
            for (int i = 0; i < N; i++)
            {
                int size = 0;
                size = CountBits(numbers[i]);

                int temp = 0;
                temp = CountEvenZeros(L, size);
                allZeros += temp;
                ChangeBits(ref L, size);
            }
            Console.WriteLine(L);
            Console.WriteLine(allZeros);
        }
    }
}
