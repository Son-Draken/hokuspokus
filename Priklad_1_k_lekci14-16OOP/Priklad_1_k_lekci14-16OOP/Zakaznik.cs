using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_1_k_lekci14_16OOP
{
    internal class Zakaznik
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Zakaznik(int Id, string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
        }

        public override string ToString()
        {
            return base.ToString();
        }




    }
}
