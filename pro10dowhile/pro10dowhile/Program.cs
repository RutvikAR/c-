using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pro10dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j;
            do
            {
                j = 1;
                do
                {
                    Console.Write(j + " ");
                    j++;
                }
                while (j <= i);
                Console.WriteLine();
                i++;
            }
            while (i <= 5);

            Console.WriteLine();

        }
    }
}
