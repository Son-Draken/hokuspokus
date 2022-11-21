using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_1_k_lekci14_16OOP
{
    internal class Adresa
    {
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int RegistryNumber { get; set; }  
        public string City { get; set; }
        public string Zip { get; set; }
        public string country;
        public string Country
        { get { return country; } set { country = "Czech Republic"; } }

        public Adresa(string Street, int HouseNumber, int RegistryNumber, string City, string Zip)
        {
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.RegistryNumber = RegistryNumber;
            this.City = City;
            this.Zip = Zip;
            this.Country = Country;

        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
