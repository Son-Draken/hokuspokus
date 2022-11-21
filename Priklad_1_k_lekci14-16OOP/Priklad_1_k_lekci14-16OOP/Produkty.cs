using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_1_k_lekci14_16OOP
{
    internal class Produkt
    {
        public string NazevProduktu { get; set; }
        public string PopisProduktu { set; get; }
        public double CenaProduktu { set; get; }

        public Produkt(string NazevProduktu, string PopisProduktu, double CenaProduktu)
        {
            this.NazevProduktu = NazevProduktu;
            this.PopisProduktu = PopisProduktu;
            this.CenaProduktu = CenaProduktu;

        }
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
