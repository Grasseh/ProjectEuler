using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem23
    {
        public static string Solve()
        {
            //Answer:4179871
            List<int> ListAbundants = Utils.GetAbundants(28123);
            List<int> ListNoSumAbundants = Utils.GetNotSumAbundants(ListAbundants, 28123);
            int Sum = 0;
            foreach (int i in ListNoSumAbundants)
            {
                Sum += i;
            }
            return Convert.ToString(Sum);
        }
    }
}
