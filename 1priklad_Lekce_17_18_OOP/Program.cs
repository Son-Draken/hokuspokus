using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1priklad_Lekce_17_18_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Uzivatel> list = new List<Uzivatel>();

            list.Add(new Uzivatel("Karel", "Novák", new DateTime(1988, 02, 05), Uzivatel.Pohlavi.Muz, Uzivatel.BarvaOci.Zelena, Uzivatel.BarvaVlasu.Blond));
            list.Add(new Uzivatel("Josef", "Nový", new DateTime(1978, 03, 19), Uzivatel.Pohlavi.Muz, Uzivatel.BarvaOci.Hneda, Uzivatel.BarvaVlasu.Hnede));
            list.Add(new Uzivatel("Jan", "Marek", new DateTime(1968, 04, 28), Uzivatel.Pohlavi.Muz, Uzivatel.BarvaOci.Cerna, Uzivatel.BarvaVlasu.Neuvedeno));
            list.Add(new Uzivatel("Karel", "Novák", new DateTime(1988, 02, 05), Uzivatel.Pohlavi.Muz, Uzivatel.BarvaOci.Zelena, Uzivatel.BarvaVlasu.Blond));
            list.Add(new Uzivatel("Marie", "Nová", new DateTime(1988, 08, 15), Uzivatel.Pohlavi.Zena, Uzivatel.BarvaOci.Modra, Uzivatel.BarvaVlasu.Cerna));
            list.Add(new Uzivatel("Věra", "Nováková", new DateTime(1978, 10, 2), Uzivatel.Pohlavi.Zena, Uzivatel.BarvaOci.Modrozelena, Uzivatel.BarvaVlasu.Blond));
            list.Add(new Uzivatel("Simona", "Mladá", new DateTime(1968, 01, 08), Uzivatel.Pohlavi.Zena, Uzivatel.BarvaOci.Neuvedeno, Uzivatel.BarvaVlasu.Hnede));
            list.Add(new Uzivatel("Michaela", "Marná", new DateTime(1958, 12, 06), Uzivatel.Pohlavi.Zena, Uzivatel.BarvaOci.Modra, Uzivatel.BarvaVlasu.Zrzava));



            //foreach (Uzivatel c in list)
            //    Console.WriteLine(c);

            //Console.WriteLine("");

            //List<Uzivatel> list2 = list.Distinct().ToList();

            //foreach (Uzivatel b in list2)
            //    Console.WriteLine(b);

            Console.WriteLine(" ");
            list = list.Distinct().ToList();

            foreach (Uzivatel c in list)
                Console.WriteLine(c);

            Console.WriteLine("hotovo");
        }
    }
}
