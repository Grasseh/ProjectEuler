using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class Number
    {
        public List<Byte> ListeNb;

        //Constr

        public Number(string _Nb){
            ListeNb = new List<Byte>();
            for (int i = 0; i < _Nb.Length; i++)
            {
                ListeNb.Add(Convert.ToByte(Convert.ToString(_Nb[_Nb.Length - i - 1])));
            }
        }

        public string GetNombre(){
            string ToReturn = "";
            for (int i = 0; i < ListeNb.Count; i++){
                ToReturn += Convert.ToString(ListeNb[ListeNb.Count - i - 1]);
            }


            return ToReturn;
        }

        public void Add(List<Number> _ListNumbers)
        {
            //V3.0
            //Features:
            //-Basic Add
            //-ClassMixing Add
            //-MultiAdd
            int Leftover = 0;
            int biggerLength = 0;
            foreach (Number i in _ListNumbers)
            {
                if (i.ListeNb.Count > biggerLength)
                    biggerLength = i.ListeNb.Count;
            }
            int j = 0;
            while ((j < biggerLength) ||(Leftover != 0)){
                if (j >= ListeNb.Count) //Only a Leftover
                    ListeNb.Add(0);
                int Sum = ListeNb[j] + Leftover;
                foreach(Number i in _ListNumbers){
                    if (i.ListeNb.Count > j)
                        Sum += i.ListeNb[j];
                }
                Leftover = Sum / 10;
                ListeNb[j] = (Byte)(Sum - Leftover * 10);
                j++;
            }
        }

        public void Multiply(int _Nb)
        {
            //V1.1
            //Basic Multiply
            int Leftover = 0;
            int i = 0;
            while(i < ListeNb.Count || Leftover != 0){
                if (i >= ListeNb.Count) //Only a Leftover
                    ListeNb.Add(0);
                int Product = ListeNb[i] * _Nb + Leftover;
                Leftover = Product / 10;
                ListeNb[i] = (Byte)(Product - Leftover * 10);
                i++;
            }
        }

        public int getLength()
        {
            return ListeNb.Count;
        }

    }


}
