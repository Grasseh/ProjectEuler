using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem30
    {
        public static string Solve()
        {
            int power = 5;
            int sum=0;
            for (int i = 10; i < 1000000;i++ )
            {
                if (i == Math.Pow(i % 10, power) +
                        Math.Pow((i % 100) / 10, power) +
                        Math.Pow((i % 1000) / 100, power) +
                        Math.Pow((i % 10000) / 1000, power) +
                        Math.Pow((i % 100000) / 10000, power) +
                        Math.Pow(i / 100000, power))
                {
                    sum += i;
                }
            }
            return Convert.ToString(sum);
        }
    }
}
