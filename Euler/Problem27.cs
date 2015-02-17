using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem27
    {
        public static string Solve()
        {
            int BestA = 0;
            int BestB = 0;
            int BestN = 0;
            for (int a = -999; a < 1000; a++)
            {
                for (int b = -999; b < 1000; b++)
                {
                    int n = 0;
                    while (Utils.isPrime(Convert.ToInt32(Math.Pow(n, 2)) + a * n + b))
                    {
                        n++;
                    }
                    if (n > BestN)
                    {
                        BestN = n;
                        BestA = a;
                        BestB = b;
                    }
                }
            }
            return Convert.ToString(BestA * BestB);
        }
    }
}
