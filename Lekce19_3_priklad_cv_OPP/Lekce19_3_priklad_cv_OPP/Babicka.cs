using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce19_3_priklad_cv_OPP
{
    class Babicka: Clovek 
    {

        public override void Vstavam(object sender, ParametryUdalostiZvoneni e)
        {
            if ( e.Hlasitost >= 20)
                Console.WriteLine("Babička vstává");

        }



    }
}
