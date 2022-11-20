using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2priklad_Lekce17_18_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
           MujList mujList = new MujList();

            mujList.Pridej(1);
            mujList.Pridej("osm");
            mujList.Pridej(3);
            mujList.Pridej(4);

         for (int i = 0; i < 100; i++)
            {
                mujList.Pridej(i);
            }

         mujList[5] = "deset";

           
            for( int i = 0; i < 10; i++)
            {
                Console.WriteLine(mujList[i]);
            }




        }
    }
}
