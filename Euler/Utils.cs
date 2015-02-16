using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    //Contains plenty of utility functions that can be reused by multiple functions.
    static class Utils
    {
        //Returns the sum of the divisors of the number received
        public static int SumDivisors(int _Nb)
        {
            int Sum = 0;
            for (int i = 1; i < _Nb; i++)
            {
                if (_Nb % i == 0)
                {
                    Sum += i;
                }
            }
            return Sum;
        }

        //Returns a list containing all the abundants number up to _Last
        public static List<int> GetAbundants(int _Last)
        {
            List<int> ListAbundants = new List<int>();
            for (int i = 1; i <= _Last; i++)
            {
                if (SumDivisors(i) < i)
                {
                    ListAbundants.Add(i);
                }
            }
            return ListAbundants;
        }
    }
}
