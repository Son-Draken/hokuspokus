using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2priklad_Lekce17_18_OOP
{
    internal class MujList
    {

        
        private object [] pole = new object[10];

        int Pocet { get; set; }


        public object this[int i]
        {
            get { return pole[i]; }
            set { pole[i] = value; }
        }

        public void Pridej(object cislo)
        {
            pole[Pocet] = cislo;
            Pocet++;
           if (Pocet == pole.Length)
            {
                object[] delsiPole = new object[Pocet*2];
                pole.CopyTo(delsiPole, 0);
                pole = delsiPole;
            }

        }

        //public override string ToString()
        //{
        //    return Pocet;
        //}

        public void vypiš()
        {
            foreach (object i in pole)
                Console.WriteLine(i);
        }

    }
}
