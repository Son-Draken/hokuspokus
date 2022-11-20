using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1priklad_Lekce_17_18_OOP
{
    internal class Uzivatel
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public enum Pohlavi { Muz, Zena }
        public Pohlavi Pohlav { get; set; }
        public BarvaOci Oci { get; set; }
        public BarvaVlasu Vlasy { get; set; }

        [Flags]
        public enum BarvaOci
        {
            Neuvedeno = 0,
            Modra = 1,
            Zelena = 2,
            Hneda = 4,
            Cerna = 8,
            Modrozelena = 16,
            Hnedozelena = 32,
        }

        public enum BarvaVlasu { Neuvedeno, Blond, Hnede, Cerna, Zrzava }

        public Uzivatel(string jmeno, string prijmeni, DateTime datumNarozeni, Pohlavi pohlavi, BarvaOci barvaOci, BarvaVlasu barvaVlasu)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            Pohlav = pohlavi;
            Oci = barvaOci;
            Vlasy = barvaVlasu;

        }

        public override bool Equals(object obj)
        {
            return ((obj is Uzivatel) && (this == (Uzivatel)obj));
        }

        public static bool operator ==(Uzivatel a, Uzivatel b)
        {
            return ((a.Jmeno == b.Jmeno) && 
                (a.Prijmeni == b.Prijmeni) && 
                (a.DatumNarozeni == b.DatumNarozeni) && 
                (a.Pohlav == b.Pohlav) && 
                (a.Oci == b.Oci) && 
                (a.Vlasy == b.Vlasy));
        }
        public static bool operator !=(Uzivatel a, Uzivatel b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return Jmeno.GetHashCode() ^ Prijmeni.GetHashCode() ^ DatumNarozeni.GetHashCode() ^ Pohlav.GetHashCode() ^ Oci.GetHashCode() ^ Vlasy.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}, oči: {3}, vlasy: {4}", Jmeno, Prijmeni, DatumNarozeni.Year, Oci, Vlasy);
            
        }

     
        }
    }









