using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3priklad_lekce_17_18_OOP
{
    public class Veta
    {
        //string Slovo { get; set; }
        string[] slova;
        public Veta (string text)
        {

            slova = text.Split(new char[] { '.', ',', '!', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            
        }

        public delegate string MapovaciFunkce (string slovo);
        public delegate string AgregacniFunkce (string vysledek, string slovo);


        public void Mapuj(MapovaciFunkce funkce)
        {
            for (int i = 0; i < slova.Length; i++)
            {
                slova[i] = funkce(slova[i]);
            }
        }

        public string Agreguj(AgregacniFunkce funkce)
        {
            string vysledek = slova[0];
            
            for (int i = 1; i < slova.Length; i++)
            {
                vysledek = funkce(vysledek, slova[i]);
            }
            return vysledek;
        }



        //pretizeni ovlivnuje samotny chod programu resp. vysledek
        //public override string ToString()
        //{
        //    return string.Join(" ", slova)+ ".";

        //}





        //puvodne co jsem napsal, funkcni jen se musi jinak zapsat 
        public override string ToString()
        {
            string vystup = "";
            foreach (string slovo in slova)
            {
                vystup += slovo + " ";
            }
            return vystup + ".";
        }


    }
}
