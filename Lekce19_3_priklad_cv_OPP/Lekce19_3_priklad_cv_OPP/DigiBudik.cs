using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce19_3_priklad_cv_OPP
{
    internal class DigiBudik: Budik 
    {
        public override void Zazvon()
        {
            Console.WriteLine("Digibudík zvoní");
            PriZazvoneni(50);
        }





    }
}
