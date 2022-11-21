using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_1_k_lekci14_16OOP
{
    internal class Objednavka : IOrder
    {

        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int RegistryNumber { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        //    public string[] products;
        public string[] Products
        {
            get { return new string[] { produkt.NazevProduktu }; }
        }


        public int[] Quantities {
            get { return new int[] { Number }; } }
     
        
        public double[] Prices {
            get { return new double[] { produkt.CenaProduktu }; } 
             }
           
      

        public Zakaznik zakaznik;
        public Adresa adresa;
        public Produkt produkt;
        public Objednavka(int Number, Produkt produkt, Zakaznik zakaznik, Adresa adresa)
        {
            this.Number = Number;
            this.FirstName = zakaznik.FirstName;
            this.LastName = zakaznik.LastName;
            this.Street = adresa.Street;
            this.HouseNumber = adresa.HouseNumber;
            this.RegistryNumber = adresa.RegistryNumber;
            this.City = adresa.City;
            this.Zip = adresa.Zip;
            this.Country = adresa.Country;
            
            this.zakaznik = zakaznik; 
            this.adresa = adresa;
            this.produkt = produkt;
         
            
           
        }
    }
}
