using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TipoDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numero = 100;
            Console.WriteLine("El valor de la variable numerò {0} ",numero);

            sbyte numero2 = 127;
            Console.WriteLine("El numero de la variable numero {0}", numero2);

            uint numero3 = 1000u;
            Console.WriteLine("El numero de la variable numero {0}", numero3);

            long numero4 = 1000L;
            Console.WriteLine("El numero de la variable numero {0}", numero4);

            DateTime fecha = new DateTime(9999, 12, 31, 23, 59, 59);
            Console.WriteLine("El numero de la variable numero {0}", fecha);

           object miObject = new object();

            //Inicializacion de variables
            int i = default;
            Console.WriteLine("El valor de la variable i {0}", i);

            //Conversion implicita
            int j = 345;
            float f = j;
            Console.WriteLine("El valor de la variable f {0}",f);

            //Conversion Explicita
            int h = 100;
            uint u = (uint)h;
            Console.WriteLine(u);

            Console.ReadLine();



        }
    }
}
