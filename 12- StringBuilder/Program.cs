using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructores del stringbuilder
            StringBuilder sb  = new StringBuilder(); //string will be appended later                                                   //or
            StringBuilder sb1 = new StringBuilder("Hello World!");
            StringBuilder sb2 = new StringBuilder(50);
            StringBuilder sb3 = new StringBuilder("Hello word", 50);
            StringBuilder sb4 = new StringBuilder("Hellow word",0,10,50);



            //Iterrar un StrinBuilder
            for (int pos = 0; pos < sb1.Length;pos++)
            {
                Console.WriteLine(sb1[pos]);
            }

            //Obtener la cadena del Stringbuilder
            string saludo = sb1.ToString();

            //ADD / AGREGAR UNA LINEA PARA UN STRINGBUILDER

            StringBuilder sb5 = new StringBuilder();
            sb5.Append("Hello ");
            sb5.Append("World!");
            sb5.Append("Hello c#");
            Console.WriteLine(sb5);

            //Agregar Cadenas con formato

            StringBuilder sbCantidad = new StringBuilder("Tu cantidad total es: ");
            sbCantidad.AppendFormat("{0:C} ", 25);
            Console.WriteLine(sbCantidad);

            //Insertar Cadena a StringBuilder

            StringBuilder sb6 = new StringBuilder("Hello World!");
            sb6.Insert(5, " C#");
            Console.WriteLine(sb6);

            //Eliminar cadena a Stringbuilder
            StringBuilder sb7 = new StringBuilder("Hello World! Hello World! Hello World!",50);
            sb7.Remove(6, 7);
            Console.WriteLine(sb7);

            //Reemplazar cadena en String Builder
            StringBuilder sb8 = new StringBuilder("Hello World");
            sb8.Replace("World", "C#");
            Console.WriteLine(sb8);
       


            Console.Read();
        }
    }
}
