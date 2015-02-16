using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem19
    {
        public static string Solve()
        {
            //Answer : 171
            int Compteur = 0;
            int Jour = 2; //0 = Monday
            for (int Annee = 1901; Annee <= 2000; Annee++)
            {
                for (int Mois = 1; Mois < 13; Mois++) //1= January
                {
                    if (Jour == 6)
                        Compteur++;
                    switch (Mois)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12: Jour = (Jour + 3) % 7;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11: Jour = (Jour + 2) % 7;
                            break;
                        case 2: if (Annee % 4 == 0)
                                Jour = (Jour + 1) % 7;
                            break;

                    }
                }
            }
            return Convert.ToString(Compteur);
        }
    }
}
