using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_1priklad_Lekce_19_OOP
{
    public delegate void Zvoneni();
    class Budik
    {
        
        


        public event Zvoneni Zvoneni;
        public void Zazvon()
        {
            if (Zvoneni != null)
                Zvoneni();
        }
            


        






        //public enum Estav { Spim, JsemVzhuru }

        //public Estav Stav { get; set; }






    }
}
