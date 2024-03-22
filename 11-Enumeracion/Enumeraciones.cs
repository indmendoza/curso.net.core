using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enumeracion
{
    enum Categories : byte
    {
        Electronics = 1,
        Food = 5,
        Automotive = 6,
        Arts = 10,
        BeautyCare = 11,
        Fashion = 15
    }
    enum Categories2
    {
        Electronics = 1,
        Food = 5,
        Arts = 10,
        Automotive = 6,
        BeautyCare = 11,
        Fashion = 15,
        WomanFashion = 15
    }

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    enum Categories3
    {
        Electronics,    // 0
        Food,           // 1
        Automotive = 6, // 6
        Arts,           // 7
        BeautyCare,     // 8
        Fashion         // 9
    }
    class Enumeraciones
    {
       

    }
}
