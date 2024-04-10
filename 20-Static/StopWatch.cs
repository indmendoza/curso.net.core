using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Static
{
    public class StopWatch
    {
        public static int NoOfInstances = 0;

        // instance constructor
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
        }

        public void PrintNoInstances() { 
         Console.WriteLine(StopWatch.NoOfInstances);
        }

        public static void Metodo1 (){ 

        }

        public static void Metodo2()
        {

        }
    }

}
