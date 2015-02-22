using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem28
    {
        public static string Solve(){
            long Sum = 1;
            long i = 1;
            long j = 2;
            for (long k = 0; k < (1001-1)/2; k++)
            {
                for (long l = 0; l < 4; l++)
                {
                    i += j;
                    Sum += i;
                }
                j += 2;
            }
            return Convert.ToString(Sum);
        }
    }
}
