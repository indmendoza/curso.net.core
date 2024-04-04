using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{
    public class FileInfo3 : IFile, IBinaryFile
    {
        
        public void OpenBinaryFile()
        {
            Console.WriteLine("Open Binary file");
        }
        public void ReadFile()
        {
            Console.WriteLine("Reading Text file");
        }

        //void IBinaryFile.ReadFile()
        //{
        //    Console.WriteLine("Reading Binary file");
        //}

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing Text file");
        }

        public void Search(string text)
        { Console.WriteLine("Searching in file");
        }

       
    }
}
