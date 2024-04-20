using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _21_InicializacionObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var std0 = new Estudiante()
            {
                StudentID = 1,
                StudentName = "Bill",
                Address = "New York",
                Age = 20
            };

            var std1 = new Estudiante();
                std1.StudentID = 1;
                std1.StudentName = "Bill";
                std1.Address = "New York";
                std1.Age = 20;

            var std2 = new Estudiante() { StudentID = 1, StudentName = "Maria", Address = "", Age =23};
            var std3 = new Estudiante() { StudentID = 2, StudentName = "Juan", Address = "", Age =33};
            var std5 = new Estudiante() { StudentID = 4, StudentName="Fernando", Address = "", Age =30};
            var std6 = new Estudiante() { StudentID = 5, StudentName="Alberto", Address = "", Age =28} ;
            var std4 = new Estudiante() { StudentID = 3, StudentName = "Pedro", Address = "", Age =32};
            
            List<Estudiante> studentList = new List<Estudiante>()
            {
                std2 , std3 , std5 , std6 
            };
        }
    }

    public class Estudiante
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
}
