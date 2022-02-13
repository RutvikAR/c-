using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonacydowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, count = 10;
            n1 = 0;
            n2 = 1;
            int i = 2;
            Console.Write(n1 + " ");
            Console.Write(n2);
            do
            {
                n3 = n1 + n2;
                Console.Write(" " + n3);
                n1 = n2;
                n2 = n3;
                i++;
            } while (i != count) ;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
