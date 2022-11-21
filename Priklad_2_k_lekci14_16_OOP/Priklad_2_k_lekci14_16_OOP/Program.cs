using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_2_k_lekci14_16_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sroubovak sroubovak = new Sroubovak("Šroubovák Phillips", 800);
            Kladivo kladivo1 = new Kladivo("Velke kladivo", 3000, true);
            Kladivo kladivo2 = new Kladivo("Bourací kladivo", 4000, true);
            Kladivo kladivo3 = new Kladivo("Kladívko", 1200, false);
            Pila pila = new Pila("Zreszla pila", 2500);
            ElektrickySroubovak elektrickySroubovak = new ElektrickySroubovak("Elektrický šroubová Bosch", 1800);

            Bedna bedna = new Bedna();
            bedna.VypisBednu();
            

            bedna.VlozeniDoBedny(kladivo3);
            bedna.VlozeniDoBedny(elektrickySroubovak);
            bedna.VlozeniDoBedny(pila);
            bedna.VlozeniDoBedny(kladivo2);
            bedna.VlozeniDoBedny(kladivo1);
            bedna.VlozeniDoBedny(pila);


            Console.WriteLine(bedna.VahaNaradiVBedne);

            bedna.VypisBednu();
            bedna.BednaNaradiPracuj();
            bedna.VahaKladivvBedne();
         
             
           



        }
    }
}
