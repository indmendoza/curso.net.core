using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();  
            estudiante1.EstudianteId = 10;
            estudiante1.Nombre = "Eduardo";
            estudiante1.ApellidoPaterno = "Gonzales";
            estudiante1.ApellidoMaterno = "Hernandez";
            string resultadoNombreCompleto1 = estudiante1.obtenerNombreCompleto();

            Estudiante estudiante2 = new Estudiante();
            estudiante2.EstudianteId = 10;
            estudiante2.Nombre = "luis";
            estudiante2.ApellidoPaterno = "Perez";
            estudiante2.ApellidoMaterno = "Ramirez";
            string resultadoNombreCompleto2 = estudiante2.obtenerNombreCompleto();

            
            Estudiante estudiante3 = new Estudiante(3,"JUAN","Sanchez","perez");
            string resultadoNombreCompleto3 = estudiante3.obtenerNombreCompleto();


            Aritmetica aritmetica1 = new Aritmetica();
            int resultadoSuma = aritmetica1.Suma(10, 30);
            aritmetica1.Saludo();
        }
    }
}
