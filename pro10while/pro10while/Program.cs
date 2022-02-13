using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pro10while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j;
            while (i < 6)
            {
                j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }

            Console.WriteLine();
        }
    }
}
