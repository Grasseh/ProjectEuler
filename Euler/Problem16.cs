using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem16
    {
        //Answer : 1366
        public static string Solve()
        {
            double Result = 0;

            Number DeuxALaMille = new Number("1");
            for (int i = 0; i < 1000; i++)
                DeuxALaMille.Multiply(2);

            for (int i = 0; i < DeuxALaMille.ListeNb.Count; i++)
                Result += DeuxALaMille.ListeNb[i];


            return Convert.ToString(Result);
        }
    }
}
