using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3priklad_Lekce_14_16_OOP
{
    abstract class Clovek : IComparable
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

        public static Random random = new Random();

       
        public Clovek(string Jmeno, string Prijmeni, DateTime DatumNarozeni)
        {
            this.Jmeno = Jmeno;
            this.Prijmeni = Prijmeni;
            this.DatumNarozeni = DatumNarozeni;
            
        }

        public int CompareTo(object obj)
        {
            Clovek clovek = (Clovek)obj;
            {
                if (this.Jmeno == clovek.Jmeno)
                    return DatumNarozeni.CompareTo(clovek.DatumNarozeni);
                //return string.Compare(this.Jmeno, clovek.Jmeno);   puvodne napsane
                return Jmeno.CompareTo(clovek.Jmeno);
            }
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + DatumNarozeni;
        }

        public static Clovek operator +(Clovek clovek1, Clovek clovek2)
        {
            if (((clovek1 is Zena) && (clovek2 is Muz))
             ||
               ((clovek1 is Muz) && (clovek2 is Zena)))

                if (random.Next(100) <= 50)
                    return new Muz("Lojza", clovek1.Prijmeni, DateTime.Now);

                else
                    return new Zena("Eva", clovek2.Prijmeni, DateTime.Now);
            return null;
        }



    }
}
