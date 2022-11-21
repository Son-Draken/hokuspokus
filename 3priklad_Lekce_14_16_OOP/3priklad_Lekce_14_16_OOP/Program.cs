using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3priklad_Lekce_14_16_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Clovek> seznamClovek = new List<Clovek>();

            seznamClovek.Add(new Muz("Karel", "Novák", new DateTime (1988, 02,05)));
            seznamClovek.Add(new Muz("Josef", "Nový", new DateTime(1978, 03, 19)));
            seznamClovek.Add(new Muz("Jan", "Marek", new DateTime(1968, 04, 28)));
            seznamClovek.Add(new Muz("Karel", "Novák", new DateTime(1958, 06, 25)));
            seznamClovek.Add(new Zena("Marie", "Nová", new DateTime(1988, 08, 15)));
            seznamClovek.Add(new Zena("Věra", "Nováková", new DateTime(1978, 10, 2)));
            seznamClovek.Add(new Zena("Simona", "Mladá", new DateTime(1968, 01, 08)));
            seznamClovek.Add(new Zena("Michaela", "Marná", new DateTime(1958, 12, 06)));

            seznamClovek.Sort();
            

            foreach (Clovek clovek in seznamClovek)
                Console.WriteLine(clovek);

            Console.WriteLine("Křížim");
            Clovek dite1 = seznamClovek[3] + seznamClovek[5];
            Console.WriteLine("Výsledkem je {0}", dite1);






        }
    }
}
