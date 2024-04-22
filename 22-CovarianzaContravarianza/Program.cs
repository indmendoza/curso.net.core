using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_CovarianzaContravarianza
{
    internal class Program
    {
        delegate Small CovarDelegado(Big mc);
        static void Main(string[] args)
        {
            Small small = new Small();
            small.Id = 1;
            small.nombre = "Juan";
            //small.tamaño = 2.30f: //No se puede por que el que contiene esta propiedad es Bigger

            Big big = new Big();
            big.Id = 2;
            big.nombre = "Nombre";
            big.Descripcion = "Persona grande";

            Bigger bigger = new Bigger();
            bigger.Id = 3;
            bigger.nombre = "Pedro";
            bigger.Descripcion = "Persona extra grande";
            bigger.tamaño = 2.30f;


            //Creacion objetos y asignacion a variables
            Small small1 = new Small();
            Small small2 = new Big();
            Small small3 = new Bigger();
            Big big1 = new Bigger();
            ///Big big2 = new Small();

            CovarDelegado del1 = Method1;
            Small sm1 = del1(new Big());

            CovarDelegado del2 = Method2;
            Small sm2 = del2(new Big());

            CovarDelegado del3 = Method3;
            Small sm3 = del3(new Big());

            CovarDelegado del4 = Method4;
            //Big sm4 = del4(new Big());

            CovarDelegado del5 = Method4;
            Small sm5 = del5(new Big());

            CovarDelegado del = Method1;
            del += Method2;
            del += Method3;
            del += Method4;

            Small small5 = del(new Big());

            CovarDelegado del6 = Method5;
            Small sml6 = del6(new Big());
        }

        public static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        public static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }

        public static Bigger Method3(Big bg)
        {
            Console.WriteLine("Method3");
            return new Bigger();
        }

        public static Small Method4(Small sml)
        {
            Console.WriteLine("Method3");
            return new Small();

        }

        static Big Method5(Small sml)
        {
            Console.WriteLine("Method3");
            return new Big();
        }

        public class Small
        {
            public int Id { get; set; }
            public string nombre { get; set; }

        }

        public class Big : Small
        {
            public string Descripcion { get; set; }
        }

        public class Bigger : Big
        {
            public float tamaño { get; set; }

        }
    }
}
