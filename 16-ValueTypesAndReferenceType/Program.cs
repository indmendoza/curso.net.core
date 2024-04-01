using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ValueTypesAndReferenceType
{
    class Program
    {

        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            //Values Type
            int i = 100;
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);
            Console.ReadLine();

            //References Type
            Estudiante estudiante = new Estudiante();
            estudiante.Id = 1;
            estudiante.Nombre = "Juan";
            Console.WriteLine("ID:{0}, Nombre: {1}",estudiante.Id,estudiante.Nombre);
            ChangeValue2(estudiante);
            Console.WriteLine("ID:{0}, Nombre: {1}", estudiante.Id, estudiante.Nombre);

            Estudiante estudiante1 = new Estudiante();
            estudiante1.Id = 1;
            estudiante1.Nombre = "JUAN";

            Estudiante estudiante2 = new Estudiante();
            estudiante2.Id = 1;
            estudiante2.Nombre = "JUAN";
               


        }
        static void ChangeValue2(Estudiante est)
        {
            est.Id = 2;
            est.Nombre = "Maria";
            Console.WriteLine("ID:{0}, Nombre: {1}", est.Id, est.Nombre);


        }
    }
    class Estudiante{
        public int Id { get; set; }

        public string Nombre { get; set; }


    }
}
