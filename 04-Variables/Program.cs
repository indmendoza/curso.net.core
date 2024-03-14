using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int num = 100;
            float rate = 10.2f;
            decimal amount = 100.50M;
            char code = 'C';
            bool isValid = true;
            string name = "Steve";

            Console.WriteLine(name);
            Console.WriteLine(rate);
            Console.WriteLine(amount);
            Console.WriteLine(code);
            Console.WriteLine(num);
            Console.WriteLine(isValid);

            //Errores
            // int num1 = "Steve";

            //Declarar y asignar despues

            int num2;
            num2 = 100;
            Console.WriteLine(num2);

            //Error Asignacion no valida
            //int i;
            //int j = i;

            int num3 = 100;
            num3 = 200;
            Console.WriteLine(num3);

            //Declarar e inicializar multiples variables
            int i, j = 10, K = 100;
            i = 1;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(K);

            //Declarar o inicializar multiples variables en multibles lineas.

            int i1= 1, 
                j1 =10, 
                K1 = 100;
            Console.WriteLine(i1);
            Console.WriteLine(j1);
            Console.WriteLine(K1);

            //Asignacion de variables
            int i3 = 100;
            int j3 = i3;

            //Variables y expresiones
            int i4 = 100;
            int j4 = i4 + 20; //120

            i4 = 200;

            j4 = i4 + 20;//220

            i4 = 300;

            Console.WriteLine("j4 = {0}, i4= {1} " ,j4, i4);

            var i5 = 5;
            Console.WriteLine(i5);
        }
    }
}
