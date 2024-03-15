using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
            Console.WriteLine("El tipo de dato de i es:{0}",i.GetType() );

            var str = "Hellow Word!!";
            Console.WriteLine("El tipo de dato de str es:{0}", str.GetType());

            var dbl = 100.50d;
            Console.WriteLine("El tipo de dato dbl es: {0}",dbl.GetType());

            var isValid = true;
            Console.WriteLine("El tipo de datos isValid es {0}:",isValid.GetType());

            var ano = new { name = "Steve", lasname ="Perez" };//Este es un anonimo
            Console.WriteLine("El tipo de datos ano es: {0}",ano.GetType());

            var arr = new[] { 1, 10, 20, 30 };
            Console.WriteLine("El tipo de dato arr es: {0}",arr.GetType());

            var file = new FileInfo("MyFile");
            Console.WriteLine("El tipo de dato file es:{0}",file.GetType());

            //var j; //Las variables tipadas deben inicializarse
            //j = 100;

            //var h = 100, j = 200, k = 300;

            var h = 100;
            var j = 200;
            var k = 300;
            Console.WriteLine(h);
            Console.WriteLine(j);
            Console.WriteLine(k);

            //Utiizando Var en un ciclo FOR
            for (var l = 0; l < 10; l++)
            {

                Console.WriteLine(i);
            }

            //string collection
            IList<String> stringList = new List<String>();
            {
               stringList.Add("C# Tutorial");
               stringList.Add("VB.NET Tutorial");
               stringList.Add("Learn C++");
               stringList.Add("MVC Tutorial");
               stringList.Add("Java");
                
            }


            //Utilizando Var en un expresion LINQ
             var result = from s in stringList 
                          where s.Contains("Tutorial")
                          select s;

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
                
            
            Console.ReadLine();
        }
        //No se puede utilizar la palabra reservada VAR en parametros
        //public static void Display(var parametro) {
        //    Console.WriteLine(parametro);
        //}
    }
}
