using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem15
    {   //Answer : 137846528820
        public static string Solve()
        {
            double Result = 1;
            for (int i = 1; i < 41; i++){
                if (i <= 20)
                {
                    Result /= i;
                }
                else
                    Result *= i;
            }


            return Convert.ToString(Result);
        }
    }
}
