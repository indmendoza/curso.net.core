using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Null
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero = null; no se puede
            Nullable<int> i = null;

            if (i.HasValue)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine("Null");
            }

            Console.WriteLine(i.GetValueOrDefault());

            int? j = null;
            double? d = null;
            Estudiante estudiante = null;

            int ? k = null;
            //int l = k;
            int h = k ?? 0;

            //Ejemplo de un campo nuleable en case (variable global)
            Estudiante estudiante1 = new Estudiante();
            Console.WriteLine(estudiante1.GetIdEstudiante());

            //Operacion de comparacion con nuleables
            int? a = null;
            int b = 10;

            //-----Esto no se puede comparar
            if (a < b)
                Console.WriteLine("a < b");
            else if (a > 10)
            {

                Console.WriteLine("a > b");
            }
            else if (a == 10)
            {
                Console.WriteLine("a == b");
            }
            else
            {
                Console.WriteLine("No se puede comparar");
            }

            if (Nullable.Compare<int>(a, b) < 0)
                Console.WriteLine("a < b");
            else if (Nullable.Compare<int> (a,b) > 0)
                Console.WriteLine("a > b");
            else
            {
                Console.WriteLine("a =b");
            }





        }
       
    }
}
