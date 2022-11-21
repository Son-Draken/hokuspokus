using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_2_k_lekci14_16_OOP
{
    abstract class Nastroj
    {
        public string Nazev { get; set; }
        public int Vaha { get; set; }

        public Nastroj(string Nazev, int Vaha)
        {
            this.Nazev = Nazev;
            this.Vaha = Vaha;
        }



        public abstract void Pracuj();
        


    }
}
