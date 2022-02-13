using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FORWHILEDOWHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            //program 9 pranav sir
            //for loop 

            int i = 1;
            for (i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //while loop 
            int j = 1;
            while (j < 6)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine();

            int k = 1;
            do
            {
                Console.WriteLine(k);
                k++;
            } 
            while (k < 6);




            //program 10 pranav sir
            //for loop 

            for (i = 0; i <= 5 ; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //while loop 
            i = 0;
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

            //do while loop

            i = 1;
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
            while(i <= 5);

            Console.WriteLine();


            /* 
               1        2       3       6       9       18   
                       *2       2*3/2   *2      6*3/2
            */
            i = 1;
            k = 1;
            for (i = 1; i <= 10; i++ )
            {
                if (i % 2 == 0)
                {
                    k = (k-1) * 2;
                    Console.Write(k + " ");
                }
                else 
                {
                    k = (k * 3) / 2;
                    Console.Write(k + " ");
                }

                k++;
            }

            Console.WriteLine();
            Console.ReadLine();


            /*
             * int unit = Convert.ToInt32(Console.ReadLine());
                if (unit <= 100)
                {
                 int tot = unit * 10;
                 Console.WriteLine("Unit :" + unit + " Cost : " + tot);
                }
                Console.ReadLine();*/
        }
    }
}
