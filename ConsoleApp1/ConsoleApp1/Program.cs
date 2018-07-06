using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumx
{
    class Program
    {
        static int sumX(int x, int n)
        {
            // your code here
            int i = 0;
            if (x > 0)
            {
                for (int a = x; a <= n; a = a + x)
                {
                    i = i + a;
                }
            }
            else if (x < 0)
            {
                for (int a = x; a >= n; a = a + x)
                {
                    i = i + a;
                }
            }
            else
            {
                return 0;
            }

            return i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("sumX(3, 10): " + (sumX(3, 10) == 18));
            Console.WriteLine("sumX(1, 10): " + (sumX(1, 10) == 55));
            Console.WriteLine("sumX(0, 10): " + (sumX(0, 10) == 0));
            Console.WriteLine("sumX(-1, 10): " + (sumX(-1, 10) == 0));
            Console.WriteLine("sumX(-1, -10): " + (sumX(-1, -10) == -55));
        }
    }
}