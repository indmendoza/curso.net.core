using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b1 = 255;
            //byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
            sbyte sb1 = -128;
            sbyte sb2 = 127;

            Console.WriteLine("Maximo de {0} y Minimo de {1} de {2}", b1.GetType(), System.Byte.MinValue, System.Byte.MaxValue);
            //El  sbyte es lo mismo que el byte, pero puede almacenar números negativos de -128 a 127.
            Console.WriteLine("Maximo de {0} y minimo de {1} de {2}", sb1.GetType(),System.SByte.MinValue, System.SByte.MaxValue);


            //SHORT//El tipo de datos ushort es un entero sin signo. Sólo puede almacenar números positivos
            short s1 = -32768;
            short s2 = 32767;
            //short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

            ushort us1 = 65535;
            //ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            Console.WriteLine("Maximo de {0} y Minimo de {1} de {2}", s1.GetType(), System.Byte.MinValue, System.Byte.MaxValue);
            Console.WriteLine("Maximo de {0} y minimo de {1} de {2}", s2.GetType(), System.SByte.MinValue, System.SByte.MaxValue);//255

            //INT
            int i = -2147483648;
            int j = 2147483647;
            //int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            //El uint es un entero sin signo de 32 bits. 
            uint ui1 = 4294967295;
            //uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            Console.WriteLine("Maximo de {0} y Minimo de {1} de {2}", i.GetType(), System.Int32.MinValue, System.Int32.MaxValue);
            Console.WriteLine("Maximo de {0} y minimo de {1} de {2}", ui1.GetType(), System.UInt32.MinValue, System.UInt32.MaxValue);//255

            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);

            //LONG ULONG
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("Maximo de {0} y Minimo de {1} de {2}", l1.GetType(), System.Int64.MinValue, System.Int64.MaxValue);
            Console.WriteLine("Maximo de {0} y minimo de {1} de {2}", ul1.GetType(), System.UInt64.MinValue, System.UInt64.MaxValue);


            //FLOAT
            float f1 = 123456.5F;
            float f2 = 1.123456f;


            Console.WriteLine("Maximo de {0} y Minimo de {1} de {2}", f1.GetType(), System.Single.MinValue, System.Single.MaxValue);
            

            ///DOUBLE
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("Maximo de {0} y Minimo de {1} de {2}", d1.GetType(), System.Double.MinValue, System.Double.MaxValue);

            //Decimal
            decimal de1 = 123456789123456789123456789.5m;
            decimal de2 = 1.1234567891345679123456789123m;

            Console.WriteLine("Maximo de {0} y Minimo de {1} de {2}", de1.GetType(), System.Decimal.MinValue, System.Decimal.MaxValue);

        }
    }

}
