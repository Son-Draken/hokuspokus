using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_2_k_lekci14_16_OOP
{
    internal class Kladivo : Nastroj
    {
        public string Nazev; 
        public int Vaha;
        public bool obourucni;

        public Kladivo(string Nazev, int Vaha, bool obourucni) : base(Nazev, Vaha)
        {
            
           this.obourucni = obourucni;
        }

        public override void Pracuj()
        {
            Console.WriteLine("Zatlukam........");
        }
     
    
    } 

        




   
}
