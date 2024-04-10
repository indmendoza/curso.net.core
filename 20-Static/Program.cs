using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Static
{
    internal class Program
    {
        static int counter = 0;
        string name = "Demo Program";
        static void Main(string[] args)
        {
            //Uso de la clase estatica
            var result = Calculator.Sum(10, 25);//Llama metodo statico
            Calculator.Store(result);

            var calType = Calculator.Type;
            Calculator.Type = "Scientific";

            //var objCalculator = new Calculator();//No se puede un objeto de una clase estatica

            ///Uso de la clase no estatica y campos estaticos
            Console.WriteLine(StopWatch.NoOfInstances);

            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances); //2 

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);//4

            //Cada objeto imprime le numero de instancia.
            sw1.PrintNoInstances();
            sw2.PrintNoInstances();
            sw3.PrintNoInstances();
            sw4.PrintNoInstances();

            counter++;

        }
        static void Display(string text)
        {
            Console.WriteLine(text);

        }
        public void SetRootFolder(string path)
        {

        }


        public void Saludar() { 
        }
    }
}
