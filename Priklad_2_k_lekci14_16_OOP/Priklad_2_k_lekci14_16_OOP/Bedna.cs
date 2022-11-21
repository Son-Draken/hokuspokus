using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_2_k_lekci14_16_OOP
{
    internal class Bedna
    {

      
        public int MaximalníNosnost { get; set; }
        public int VahaNaradiVBedne { get; set; }

        public int VahaKladiv { get; set; }


        private List<Nastroj> BednaList;

        public Bedna()
            {
            BednaList = new List<Nastroj>();
            MaximalníNosnost = 10000;
            VahaNaradiVBedne = 0;
            }


        public void VlozeniDoBedny(Nastroj vlozenyNastroj)
        {

            if (VahaNaradiVBedne <  MaximalníNosnost)
            {
                BednaList.Add(vlozenyNastroj);
                VahaNaradiVBedne = VahaNaradiVBedne + vlozenyNastroj.Vaha;
                if (VahaNaradiVBedne > MaximalníNosnost)
                {
                    BednaList.Remove(vlozenyNastroj);
                    VahaNaradiVBedne = VahaNaradiVBedne - vlozenyNastroj.Vaha;
                }
            }
            //if (VahaNaradiVBedne < MaximalníNosnost)
            //{
            //    VahaNaradiVBedne = VahaNaradiVBedne + vlozenyNastroj.Vaha;
            //    BednaList.Add(vlozenyNastroj);
            //}
            //if (VahaNaradiVBedne > MaximalníNosnost)
            //    {
            //    BednaList.Remove(vlozenyNastroj);
            //    VahaNaradiVBedne = VahaNaradiVBedne - vlozenyNastroj.Vaha;
            //    }
        }

        public void VyndaniZBedny(Nastroj vyndejNastroj)
        {
            BednaList.Remove(vyndejNastroj);
        }

        public void VypisBednu()
        {
            Console.Write("V bedně je:");
            foreach (Nastroj nastroj in BednaList)
                Console.Write(" {0} ,", nastroj.Nazev);
                Console.WriteLine();
            if (BednaList.Count < 1)
                Console.WriteLine("Bedna je prázdná");
        }

        public void BednaNaradiPracuj()
        {
            foreach (Nastroj nastroj in BednaList)
                nastroj.Pracuj();
          
        }

        public void VahaKladivvBedne()
        {
            VahaKladiv = 0;

            foreach (Nastroj nastroj in BednaList)
            {
                if (nastroj is Kladivo)
                {
                    VahaKladiv += nastroj.Vaha;
                }
            }

            Console.WriteLine("Vaha kladiv v bedně je: {0}.", VahaKladiv);

        }

    }
}
