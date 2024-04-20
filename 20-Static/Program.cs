using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Static
{
    internal class Program //:ProgramBase --->Herencia
    {
        static int counter = 0;
        string name = "Demo Program";
        static void Main(string[] args)
        {
            //Prueba de contructores estaticos
            StopWatch sw00 = new StopWatch();
            StopWatch sw01 = new StopWatch();
            StopWatch.DisplayInfo();
            StopWatch.DisplayInfo();


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
            Display("Hellow World!");

            Program program = new Program();
            program.name = "New Demo Program";
            program.SetRootFolder("C:\\MyProgram");
            Console.WriteLine(Program.GetSaludo());

        }
        static void Display(string text)
        {
            Console.WriteLine(text);

        }
        public void SetRootFolder(string path)
        {

        }
        public static string GetSaludo()
        {
            //static string saludo = "Hola mundo"; No se puede definir variables estaticas
            //return "Hola mundo" name; //No se puede mandar a llamar una variable no estatic por que el metodo es estatico
            return "Hola mundo";
        }
        public static string GetSaludo(string nombre) {
            return "Hola "+ nombre;
        }
        public static string GetSaludo(string nombre, string apellido) { 
            return "Hola "+nombre+ " " +apellido;
        }

    }
}
