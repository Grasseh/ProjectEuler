using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem18
    {
        //Answer = 1074
        static int[,] Grid = new int[15,15];

        public static string Solve(){
            string[] kk = new string[15];
            kk[0] ="75";
            kk[1] = "95 64";
            kk[2] = "17 47 82";
            kk[3] = "18 35 87 10";
            kk[4] = "20 04 82 47 65";
            kk[5] = "19 01 23 75 03 34";
            kk[6] = "88 02 77 73 07 63 67";
            kk[7] = "99 65 04 28 06 16 70 92";
            kk[8] = "41 41 26 56 83 40 80 70 33";
            kk[9] = "41 48 72 33 47 32 37 16 94 29";
            kk[10] = "53 71 44 65 25 43 91 52 97 51 14";
            kk[11] = "70 11 33 28 77 73 17 78 39 68 17 57";
            kk[12] = "91 71 52 38 17 14 91 43 58 50 27 29 48";
            kk[13] = "63 66 04 68 89 53 67 30 73 16 69 87 40 31";
            kk[14] = "04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
            //Fill la Grid
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (j > i)
                        Grid[i, j] = 0;
                    else
                        Grid[i, j] = Convert.ToInt32(kk[i].Substring(j * 3, 2));
                }
            }
                        
            /*
            for (int i = 0; i < 15; i++)
            {
                string Ligne = "";
                for (int j = 0; j < 15; j++)
                {
                    Ligne += Convert.ToString(Grid[i, j]) + " ";
                }
                Console.WriteLine(Ligne);
            }
             */

            //Solve
            int Solution = Naviguer(0,0,0);
            return Convert.ToString(Solution);
        }

        private static int Naviguer(int _X, int _Y, int _Somme)
        {
            //Vérifier si au bas de la pyramide
            if (_Y == 14)
                return (_Somme +Grid[_Y,_X]);
            else
            {
                //Tester Gauche
                int Grand = Naviguer(_X, _Y + 1, _Somme + Grid[_Y, _X]);
                //Tester Droite
                int Droite = Naviguer(_X + 1, _Y + 1, _Somme + Grid[_Y, _X]);
                if (Droite > Grand)
                    Grand = Droite;
                return Grand;
            }
        }
    }
}
