using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_2_k_lekci14_16_OOP
{
    internal class ElektrickySroubovak : Sroubovak
    {

        public int KapacitaBaterie { get; set; }

        public ElektrickySroubovak(string Nazev, int Vaha) : base(Nazev, Vaha)
        {
        }
    }
}
