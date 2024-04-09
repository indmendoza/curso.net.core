using System.Runtime.CompilerServices;

namespace _18_Operandos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5 + 5;
            int y = x + 5;
            int z = x + y;
            float f = 3.5f + 5.25f;
            string greet = "hello " + "World";

            Console.WriteLine("x:{0}", x);
            Console.WriteLine("y:{0}", y);
            Console.WriteLine("z:{0}", z);
            Console.WriteLine("f:{0}", f);
            Console.WriteLine("gree:{0}", greet);

            //Operaciones aritmeticas con modulo
            int resultado = 13 % 2;
            Console.WriteLine(resultado);

            //Operaciones unitarias
            int b = 5;
            b++;
            int c = b++;
            int e = ++b;
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(b);

            //Operaciones abreviadas
            int h = 10;
            h += 5;    //es igual a ------> h = h + 5;
            Console.WriteLine(h);
            h -= 5;    //es igual a ------> h = h - 5;
            Console.WriteLine(h);
            h *= 5;    //es igual a ------> h = h * 5;
            Console.WriteLine(h);
            h /= 5;    //es igual a ------> h = h / 5;
            Console.WriteLine(h);

            //Operacion de asignacion nula
            string str = "Hellow world";
            str ??= "Hola mundo";
            Console.WriteLine(str);

            //Operadores de comparacion
            bool resultado1 = false;
            int j = 10;
            int i = 10;

            resultado1 = j < i;
            resultado1 = j > j;
            resultado1 = j >= i;
            resultado1 = j <= i;
            resultado1 = j == i;
            resultado1 = j != i;

            //Operacion de negacion
            bool bvar = false;
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            Console.WriteLine(!bvar);
            Console.WriteLine(!(5 >3));

            //Operacion Logica AND
            bool resultado2; 
            resultado2 = OperandorTrue() && OperandorTrue();
            if(resultado2)
                Console.WriteLine(resultado2);

            resultado2 = OperandorTrue() && OperandorFalse();
            if(resultado2)
                Console.WriteLine(resultado2);

            resultado2 = OperandorFalse() && OperandorTrue();
            if(resultado2)
                Console.WriteLine(resultado2);

            resultado2 = OperandorFalse() && OperandorFalse();
            if(resultado2)
                Console.WriteLine(resultado2);

            //Operacion Logica OR
             resultado2 = false;
            resultado2 = OperandorTrue() || OperandorTrue();
            if (resultado2)
                Console.WriteLine(resultado2);

            resultado2 = OperandorTrue() || OperandorFalse();
            if (resultado2)
                Console.WriteLine(resultado2);

            resultado2 = OperandorFalse() || OperandorTrue();
            if (resultado2)
                Console.WriteLine(resultado2);

            resultado2 = OperandorFalse() || OperandorFalse();
            if (resultado2)
                Console.WriteLine(resultado2);

            List<string> list = new List<string>();
            list.Any(cadena => cadena.Length >= 0);

            List<int> ListInt = new List<int>();
            ListInt.Any(entero => entero == 0);

            List<Estudiante> listEstudiante = new List<Estudiante>();
            listEstudiante.Any(estudiante => estudiante.Nombre == "JUAN");


            int a1 = 5 + 3 * 3;
            float b1 = (5 + 3) * 3 / 2;
            int c1 = (3*3) * 3 / 2;
            int d1 = (3 * 3) * (3 * 3 + 5);

        }

        private static bool OperandorTrue(){ 
        return true;
        }

        private static bool OperandorFalse() {
            return false;
        }

        internal class Estudiante { 
            public string Nombre { get; set; }
        }
    }
}
