using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enumeracion
{
    class Program
    {
        static void Main(string[] args)
        {

            
            WeekDays dia1 =WeekDays.Monday;
            WeekDays dia2 =WeekDays.Friday;
            Console.WriteLine((int)dia1);
            Console.WriteLine((int)dia2);

            int day = (int)WeekDays.Friday;
            Console.WriteLine(day);

            Console.WriteLine("aqui");
            WeekDays _weekday = (WeekDays)5;
            Console.WriteLine(_weekday); 

            Categories categoria = Categories.Electronics;
            Categories categoria2 = Categories.Automotive;
            Categories categoria3 = Categories.Arts;
            Console.WriteLine((int)categoria);
            Console.WriteLine((int)categoria2);
            Console.WriteLine((int)categoria3);

            Categories2 categoria4 = Categories2.Automotive;
            Categories2 categoria5 = Categories2.Fashion;
            Categories2 categoria6 = Categories2.WomanFashion;
            Console.WriteLine("Separador");
            Console.WriteLine((int)categoria4);
            Console.WriteLine((int)categoria5);
            Console.WriteLine((int)categoria6);
        }
    }
    
}
