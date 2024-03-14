using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School;

namespace _03_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School.Student std = new School.Student();
            School.Course cs = new School.Course();

            School.Education.Student student1 = new School.Education.Student();
            School.Education.Course course1 = new School.Education.Course();
        }
    }
}
