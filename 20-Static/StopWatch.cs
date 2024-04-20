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
        static StopWatch() {
            Console.WriteLine("Llama a el constructor estatico");
        }

        // instance constructor
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
            Console.WriteLine("Llama al constructor de instancia");
        }

        //static method
        public static void DisplayInfo() {
            Console.WriteLine("DisplayInfo called");        
        }

        //instance method
        public void Start() { 
        
        }
        //instance method
        public void Stop() { }

        //public StopWatch() {
        //    StopWatch.NoOfInstances++;
        //}
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
