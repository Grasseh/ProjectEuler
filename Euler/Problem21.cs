using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem21
    {
        public static string Solve()
        {
            //Answer : 31626
            List<int> ListAmicables = new List<int>();
            for (int i = 1; i < 10000; i++)
            {
                int k = Utils.SumDivisors(i);
                if (Utils.SumDivisors(k) == i && k != i)
                {
                    ListAmicables.Add(i);
                }
            }
            int Somme = 0;
            foreach (int i in ListAmicables)
            { 
                Somme += i; 
            }
            return Convert.ToString(Somme);
        }

        
    }
}
