using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 255;
         //   byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
            sbyte sb1 = -128;
            sbyte sb2 = 127;

            Console.WriteLine(Byte.MaxValue);//255
            Console.WriteLine(Byte.MinValue);//0
            Console.WriteLine(SByte.MaxValue);//127
            Console.WriteLine(SByte.MinValue);//-128
            Console.ReadLine();
        }
       
    }
}
