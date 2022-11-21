using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3priklad_lekce_17_18_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Veta veta = new Veta("Delegát v C# .NET funguje jako odkaz na metodu.");


            Console.WriteLine(veta);

            veta.Mapuj(s => s.ToUpper());
            Console.WriteLine(veta);

            string VelkaPismena(string slovo)
            {
                return slovo.ToLower();
            }

            veta.Mapuj(VelkaPismena);
            Console.WriteLine(veta);



            string DoplneniMezer(string vysledek, string slovo)
            {
                return vysledek + "-" + slovo;

            }
            Console.WriteLine(veta.Agreguj(DoplneniMezer));

            veta.Agreguj(DoplneniMezer);
            Console.WriteLine(veta);
            //lambda vyraz anonymni dlegat
            Console.WriteLine(veta.Agreguj((a, b) => a + "-" + b));
            //anonymni delegat
            Console.WriteLine(veta.Agreguj(delegate (string a, string b) { return a + "_" + b; }));
            
            
            
            Console.WriteLine(veta);

        }
    }
}
