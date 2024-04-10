using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Static
{
    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";

        public static int MyProperty { get; set; }
        
        //Constructor
        static Calculator() { }

        public static int Sum(int num1, int num2) 
        { 
            return num1 + num2; 
        }

        public static void Store(int result)
        { 
            _resultStorage = result;
        }

    }

    ////una clase static no puede heredar
    //public class CalculatorV2: Calculator { }
}
