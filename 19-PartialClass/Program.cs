using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empleado = new Employee(1, "JUAN");
            empleado.DisplayEmpInfo();

            Employee empleado2 = new Employee();

            Console.ReadLine();
        }
    }
}
