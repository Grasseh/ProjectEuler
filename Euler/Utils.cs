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
        //An abundant number is a number that has a higher sum of its divisors than itself.
        //For example, 12's divisors are 1,2,3,4 and 6. The sum of these divisors is 16.
        //16>12, thus 12 is an abundant number.
        public static List<int> GetAbundants(int _Last)
        {
            List<int> ListAbundants = new List<int>();
            for (int i = 1; i <= _Last; i++)
            {
                if (SumDivisors(i) > i)
                {
                    ListAbundants.Add(i);
                }
            }
            return ListAbundants;
        }

        //Returns a list containing all numbers which are not the sum of any combination of two abundant numbers.
        //Abundant numbers are defined in the GetAbudants function
        public static List<int> GetNotSumAbundants(List<int> ListAbundants,int _Last)
        {
            List<int> ListNotSum = new List<int>();
            
            for (int k = 1; k <= _Last; k++)
            {
                int i = 0;
                bool Sum = false;
                while (!Sum && i < ListAbundants.Count && ListAbundants[i] < k )
                {
                    int j = i;
                    while (!Sum && j < ListAbundants.Count && ListAbundants[j] < k)
                    {
                        Sum = ListAbundants[i] + ListAbundants[j] == k;
                        j++;
                    }
                    i++;
                }
                if (!Sum)
                {
                    ListNotSum.Add(k);
                }
            }
            return ListNotSum;
        }

        //Returns if the received number is a prime
        public static bool isPrime(int _Nb)
        {
            return SumDivisors(_Nb) == 1;
        }

        //Returns the factorial of the number received 
        public static Number factorial(int _Nb)
        {
            
            if(_Nb <= 0)
            {
                return new Number("0");
            }
            else
            {
                Number Result = new Number("1");
                for (int i = 2; i <= _Nb; i++)
                {
                    Result.Multiply(i);
                }
                return Result;
            }
        }

        //Returns the factorial of the number received, MAX 12
        public static int factorial(int _Nb)
        {

            if (_Nb <= 0 || _Nb >= 13)
            {
                return 0;
            }
            else
            {
                int Result = 1;
                for (int i = 2; i <= _Nb; i++)
                {
                    Result *= i;
                }
                return Result;
            }
        }

    }
}
