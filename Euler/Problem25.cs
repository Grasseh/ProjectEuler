using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem25
    {
        public static string Solve()
        {
            Number NbA = new Number("1");
            Number NbB = new Number("1");
            int i=2;
            while (NbA.getLength() < 1000 && NbB.getLength() < 1000)
            {
                NbA.Add(NbB);
                NbB.Add(NbA);
                i += 2;
            }
            if (NbA.getLength() < 1000)
            {
                return Convert.ToString(i);
            }
            else
            {
                return Convert.ToString(i - 1);
            }
        }
    }
}
