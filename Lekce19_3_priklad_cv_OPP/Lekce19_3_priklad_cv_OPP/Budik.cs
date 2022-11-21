using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce19_3_priklad_cv_OPP
{

    

    internal class Budik
    {
        
        //událost eventhandler s odkazem na tridu Parametryzvoneni
        public event EventHandler<ParametryUdalostiZvoneni> Zvoneni;

        //metoda zazvon zazvnoní a zada hlasitost 10
        public virtual void Zazvon()
        {
            Console.WriteLine("Budík zvoní");
            PriZazvoneni(10);
        }

        //metoda na zmenu/vytvoreni nového paraetru hlasitost /// nastavi 10 do parameru
      protected void PriZazvoneni(int hlasitost)
        {
            if (Zvoneni != null)
                Zvoneni(this, new ParametryUdalostiZvoneni(hlasitost));
        }

    }
}
