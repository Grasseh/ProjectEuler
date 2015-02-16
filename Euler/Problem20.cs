using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem20
    {
        public static string Solve()
        {
            //Answer : 648
            string Solution = "";
            Number Factorial = new Number("1");
            for (int i = 1; i < 101; i++)
                Factorial.Multiply(i);
            Solution = Factorial.GetNombre();
            int Solution2 = 0;
            for (int i = 0; i < Solution.Length; i++)
                Solution2 += Convert.ToInt32(Convert.ToString(Solution[i]));
            return Convert.ToString(Solution2);
        }
    }
}
