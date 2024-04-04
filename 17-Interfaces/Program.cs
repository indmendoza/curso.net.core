using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de la BD
            //IDBContext dBContext = new SQLDBContext();
            IDBContext dBContext = new OracleDBContext();
            dBContext.insert(new object());
            dBContext.update(new object());

            //Ejemplo de file info con interfaces, con la propia clase y con Object
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();
            Object file3 = new FileInfo();

            //Interface
            file1.ReadFile();   
            file1.WriteFile("Hola");

            ///Con la propia clase
            file2.ReadFile();
            file2.WriteFile("Hola mundo");
            Console.WriteLine(file2.fileName);
            file2.fileName = "OtroArchivo.txt";
            Console.WriteLine(file2.fileName);

            //con la clase object
            Console.WriteLine(file3);

            IFile file4 = new FileInfo2();
            FileInfo2 file5 = new FileInfo2();

            file4.ReadFile();
            file4.WriteFile("Hola");

            //file5.ReadFile();
            //file5.WriteLine();
            file5.Search("Hola");

            //ejemplo file info con multiples interfaces
            IFile file6 = new FileInfo3();
            IBinaryFile file7 = new FileInfo3();
            FileInfo3 file8 = new FileInfo3();

            file6.ReadFile();
            file6.WriteFile("Hola");
            //file6.OpenBinaryFile();
            //file6.Search("Hola");

            file7.OpenBinaryFile();
            file7.ReadFile();
            //file7.WriteFile("Hola");


            //file8.OpenBinaryFile();
            //file8.ReadFile();
            //file8.WriteFile();
            file8.Search("Hola");

        }
    }
}
