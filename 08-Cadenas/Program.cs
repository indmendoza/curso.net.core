using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Cadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = "S";
            string word = "String";
            string text = "This is a string.";

            string str1 = "Hello"; // uses string keyword

            String str2 = "Hello"; // uses System.String class
            //--------------------------------------------------------------------------------

            char[] chars = { 'H', 'E', 'L', 'L', 'O', 'W' };
            string str3 = new string(chars);
            String str4 = new string(chars);

            foreach (var elementoArreglo in chars)
            {

                Console.WriteLine(elementoArreglo);
            }

            //---------------------------------------------------------------------
            string text1 = "This is a \"string\" in C#.";
            string str = "xyzdef\rabc";

            Console.WriteLine(str);

            //----------------------------------------------------------------------
            string str5 = @"xyzdef\rabc";
            string path = @"\\mypc\shared\project";
            string email = @"test@test.com";

            Console.WriteLine(str5);
            Console.WriteLine(path);
            Console.WriteLine(email);

            //----------------------------------------------------------------------
            string str6 = "this is a \n" +
                            "multi line \n" +
                            "string"; 

            // Verbatim string
            string str7 = @"this is a 
                            multi line 
                            string";

            Console.WriteLine(str6);
            Console.WriteLine(str7);

            ///--------------------------------------------------------------------------
            string text2 = "This is a \"string\" in C#."; // valid
            //string text = @"This is a "string." in C#."; // error
            //string text = @"This is a \"string\" in C#."; // error
            string text3 = @"This is a ""string"" in C#."; // valid

            Console.WriteLine(text2);
            Console.WriteLine(text3);

            //------------------------------------------------------------------------------
            string name = "Mr." + "James " + "Bond" + ", Code: 007";

            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string agent = "Mr." + firstName + " " + lastName + ", Code: " + code;
            
            Console.WriteLine(name);

            //---------------------------------------------------------------------------------
            string firstName1 = "James";
            string lastName1 = "Bond";
            string code1 = "007";

            string fullName = $"Mr. {firstName1} {lastName1}, Code: {code1}";
            Console.WriteLine(fullName);

        }
    }
}
