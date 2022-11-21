using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce19_3_priklad_cv_OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek clovek = new Clovek();
            Babicka babicka = new Babicka();
            
            Budik budik = new Budik();
            DigiBudik digiBudik = new DigiBudik();

            budik.Zvoneni += clovek.Vstavam;
            budik.Zvoneni += babicka.Vstavam;
            digiBudik.Zvoneni += clovek.Vstavam;
            digiBudik.Zvoneni += babicka.Vstavam;

            budik.Zazvon();
            digiBudik.Zazvon();
            





        }
    }
}
