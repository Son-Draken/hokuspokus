using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce19_3_priklad_cv_OPP
{
    class Clovek
    {
        public virtual void Vstavam(object sender, ParametryUdalostiZvoneni e)
        {
            Console.WriteLine("ČLověk vstává");
        }

       

    }
}
