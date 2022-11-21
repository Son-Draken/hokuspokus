using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_2_k_lekci14_16_OOP
{
    internal class Sroubovak : Nastroj
    {
        public Sroubovak(string Nazev, int Vaha) : base(Nazev, Vaha)
        {
        }

        public override void Pracuj()
        {
            Console.WriteLine("Šroubuji......");
        }
    }
}
