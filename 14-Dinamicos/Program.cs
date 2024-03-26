using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Dinamicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic MyDynamicVar = 1;

            Console.WriteLine(MyDynamicVar.GetType());


            MyDynamicVar = 100;
            Console.WriteLine("Valor: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello world";
            Console.WriteLine("Valor:{0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Valor: {0}, Type: {1}",MyDynamicVar, MyDynamicVar.GetType());
            
            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Valor: {1},Type:{0}", MyDynamicVar,MyDynamicVar.GetType());


            dynamic d1 = 100;
            int i = d1;

            d1 = "Hello";
            string greet = d1;

            d1 = DateTime.Now;
            DateTime dt = d1;


            dynamic studiante = new Estudiante();
            //studiante.DisplayStudentInfo(1,"Bill");
            //studiante.DisplayStudentInfo("1");
            studiante.FakeMethod();




            Console.ReadLine();
        }
    }
}
