using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Anonimo
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de datos vs tipos anonimos
            Estudiante estudiante = new Estudiante();
            var estudiante2 = new Estudiante();
            var estudiante3 = new { Id = 1, Nombre = "Juan", ApellidoPaterno = "Perez" };

            Console.WriteLine(estudiante3.Id);
            Console.WriteLine(estudiante3.Nombre);
            Console.WriteLine(estudiante3.ApellidoPaterno);

            //Las propiedades anonimas son de solo lectura
            //student.Id = 2;//Error: cannot chage value
            //student.FirstName = "Steve";//Error: cannot chage value

            //Tipos de datos anonimos Anidados4
            var studiante4 = new
            {
                Id = 1,
                Nombre = "Juan",
                ApellidoPaterno = "Perez",
                Direccion = new
                {
                    Id = 1,
                    Ciudad = "Londres",
                    Country = "Inglaterra"
                }
            };
            Console.WriteLine(studiante4);

            //Arreglo con objetos anonimos
            var estudiantes = new[]
            {
                new { Id = 1, Nombre = "JUAN", ApellidoPaterno="Perez"},
                new { Id = 1, Nombre = "JUAN", ApellidoPaterno="Perez"},
                new { Id = 1, Nombre = "JUAN", ApellidoPaterno="Perez"},

            };
            Console.WriteLine(estudiantes);

            //los objetos anonimos aplicados en consultas LINQ
            IList<Estudiante> listaEstudiantes = new List<Estudiante>()
            {
                new Estudiante() { EstudianteId = 1, Nombre ="Juan", Edad = 25 },
                new Estudiante() { EstudianteId = 2, Nombre="Pedro", Edad = 30 },
                new Estudiante() { EstudianteId = 2, Nombre="Maria", Edad = 28 },
                new Estudiante() { EstudianteId = 2, Nombre="Jose", Edad = 32 },
                new Estudiante() { EstudianteId = 2, Nombre="Alonso", Edad = 31 },


            };

            //Consulta LINQ
            var consultaEstudiante = from s in listaEstudiantes
                                     select new { Id = s.EstudianteId, Nombre = s.Nombre };
            foreach(var estudiante5 in consultaEstudiante)
            {

                Console.WriteLine("Id: " + estudiante5.Id + "Nombre: " + estudiante5.Nombre);
            }


            //Obtener el tipo de dato de iun anonimo
            var estudiante6 = new { Id = 2, FirsName = "James", LastName = "Bond" };
            Console.WriteLine(estudiante6.GetType().ToString());


            Console.Read();


        }

    }

    class Estudiante
    {


        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

    }

}

