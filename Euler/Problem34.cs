using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem34
    {
        public static string Solve()
        {
            List<int> List = new List<int>();
            for(int i =10;i<3265760;i++)
            {
                if(i == Utils.factorial(i % 10) +
                        Utils.factorial(i % 100 / 10) +
                        Utils.factorial(i % 1000 / 100) +
                        Utils.factorial(i % 10000 / 1000) +
                        Utils.factorial(i % 100000 / 10000) +
                        Utils.factorial(i % 1000000 / 100000) +
                        Utils.factorial(i / 1000000) + Convert.ToString(i).Split('0').Length - 1)
                {
                    List.Add(i);
                }
            }
            return Convert.ToString(List.Sum());
        }
    }
}
