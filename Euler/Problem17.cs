using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem17
    {
        private static int LettresNombre(int _Nombre, bool _Dizaine, bool _Teens)
        {
            
            int ToReturn = 0;
            if (_Dizaine)
            {
                if (_Teens)
                {
                    switch (_Nombre)
                    {
                        case 0: ToReturn = 3;//ten
                            break;
                        case 1: //eleven
                        case 2: ToReturn = 6;
                            break;//twelve
                        case 3: //thirteen
                        case 4: //fourteen
                        case 8: //eighteen
                        case 9: ToReturn = 8;
                            break;//nineteen
                        case 5: //fifteen
                        case 6: ToReturn = 7;
                            break;//sixteen
                        case 7: ToReturn = 9;
                            break;//seventeen
                    }
                }
                else
                {
                    switch (_Nombre)
                    {
                        case 2: //twenty
                        case 3: //thirty
                        case 8: //eighty
                        case 9: ToReturn = 6; //ninety
                            break;
                        case 4: //forty
                        case 5: //fifty
                        case 6: ToReturn = 5; //sixty
                            break;
                        case 7: ToReturn = 7; //seventy
                            break;
                    }
                }
            }
            else
            {
                switch (_Nombre)
                {
                    case 1: //one
                    case 2: //two
                    case 6: ToReturn = 3; //six
                        break;
                    case 4: //four
                    case 5: //five
                    case 9: ToReturn = 4; //nine
                        break;
                    case 3: //three
                    case 7: //seven
                    case 8: ToReturn = 5; //eight
                        break;
                }
            }
            return ToReturn;
        }

        public static string Solve()
        {
            //21124
            int Compteur = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i / 100 != 0)
                { //Centaine
                    Compteur += 7; //hundred
                    Compteur += LettresNombre(i / 100, false,false);
                    if (((i / 10) % 10 != 0) || (i % 10 != 0)) //Unité ou dizaine présente
                        Compteur += 3;//AND
                }
                if ((i/10) % 10 != 0) //dizaine
                {
                    if ((i / 10) % 10 == 1) //ten..nineteen
                        Compteur += LettresNombre(i % 10, true, true);
                    else
                        Compteur += LettresNombre((i / 10) % 10, true, false);
                }
                if ((i % 10 != 0) && (i / 10) % 10 != 1)
                { //Unité pas de 10 à 19
                    Compteur += LettresNombre(i % 10, false, false);
                }
            }
            Compteur += 11;//one thousand
                return Convert.ToString(Compteur);
        }
    }
}
