using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem14
    {
        //ANSWER : 837799
        public static string Solve()
        {
            long BestNumber = 0;
            long BiggestLength = 0;
            
            for (long i = 1; i < 1000000; i++) {

                long calc = i;
                long length = 1;
                while (calc != 1)
                {
                    length++;
                    if (calc % 2 == 0) //even
                        calc /= 2;
                    else
                        calc = calc * 3 + 1; 
                }
                if (length > BiggestLength)
                {
                    BiggestLength = length;
                    BestNumber = i;
                }
                //Console.WriteLine(i);
            }

            return Convert.ToString(BestNumber);
        }
    }
}
