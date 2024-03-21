using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creacion de Fechas
            DateTime dt1 = new DateTime(); // assigns default value 01/01/0001 00:00:00
            Console.WriteLine("El valor de dt1 es:{0}",dt1);

            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine("El valor de dt2 es: {0}", dt2);

            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine("El valor de dt3 es: {0}",dt3);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine("El valor de dt3 es: {0}", dt4.ToLocalTime());



            try
            {

                DateTime dt5 = new DateTime(2015, 12, 32);
                Console.WriteLine("El valor de dt5 es {0}", dt5);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error de conversion: {0}", ex);
            }

            //Ticks
            //  2/3/2323 8:52:15 --> #Ticks
            //  2/3/2023 8:53:30 --> #Ticks

            DateTime dt6 = new DateTime(636370000000000000);
            Console.WriteLine("El valor de dt6 es {0}", dt6);

            Console.WriteLine("La fecha minima es {0}", DateTime.MinValue);
            Console.WriteLine("El ticks de la fecha minima es {0}", DateTime.MinValue.Ticks);

            Console.WriteLine("La fecha maxima es {0}", DateTime.MaxValue);
            Console.WriteLine("El ticks de la fecha maxima es {0}", DateTime.MaxValue.Ticks);

            //Campos estaticos
            DateTime fechaHoraActual = DateTime.Now;  //returns current date and time
            Console.WriteLine("El valor de fechaHoraActual es {0}", fechaHoraActual);

            DateTime fechaActual = DateTime.Today;
            Console.WriteLine("El valor de fechaActual es {0}", fechaActual);

            DateTime fechaHoraActualUTC = DateTime.UtcNow;// returns current UTC date and time
            Console.WriteLine("El volar de la fechaActual es {0}",fechaHoraActualUTC);

            DateTime fechaHoraMinima = DateTime.MinValue;
            Console.WriteLine("El valor de la fechaHoraActualUTC es {0}",fechaHoraMinima);

            DateTime fechaHoraMaxima = DateTime.MaxValue;
            Console.WriteLine("El valor de  fechaHoraMaxima es {0}",fechaHoraMaxima);


            //Times Span
            //suma
            DateTime dt7 = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25,20,55);
            DateTime nuevaFechaHora = dt7.Add(ts);
            Console.WriteLine("El valor de nuevaFechaHora es {0}",nuevaFechaHora);

            //Resta
            DateTime dt8 = new DateTime(2015,12,31);
            DateTime dt9 = new DateTime(2016,2,2);
            TimeSpan ts2 = dt9.Subtract(dt8);
            Console.WriteLine("El resultado es {0}",ts2);

            DateTime fechaHoraActual1 = DateTime.Now;
            DateTime fechaNAcimiento = new DateTime(200,03,01, 8,0,0);
            TimeSpan ts3 = fechaHoraActual1.Subtract(fechaNAcimiento);
            Console.WriteLine("El valor de ts3 es {0}",ts3);

            ///Operadores
            DateTime dt10 = new DateTime(2015,12,20);
            DateTime dt11 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - dt1); //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2); //False
            Console.WriteLine(dt1 < dt2); //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2);//True

            //Conversion de fecha; de cadena a fecha y hora
            //conversion tryparce

            var str = "aa/12/2020";
            DateTime dt;

            bool fechaEsValida = DateTime.TryParse(str, out dt);

            if (fechaEsValida)
            {
                Console.WriteLine("La fecha convertida es {0}", dt);
            }
            else {
                Console.WriteLine($"{str} no es una fecha valida");
            }

            //conversion con parse
            try {
                DateTime dt12 = DateTime.Parse(str);
                Console.WriteLine("La fecha convertida es {0}", dt12);

            }
            catch(Exception) {
                Console.WriteLine($"{str} no es una fecha valida");
            }

        }
    }
}
