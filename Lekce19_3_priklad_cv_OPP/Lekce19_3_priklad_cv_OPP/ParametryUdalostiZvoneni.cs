using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce19_3_priklad_cv_OPP
{
    internal class ParametryUdalostiZvoneni: EventArgs
    {
        public int Hlasitost { get; set; }

        public ParametryUdalostiZvoneni(int hlasitost)
        {
            Hlasitost = hlasitost;
        }

    }
}
