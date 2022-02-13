using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 values with arithmetic task");
            int a = Convert.ToInt32(Console.ReadLine());
            char b = Convert.ToChar(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d;
            switch (b)
            { 
                case '+':
                    d = a+c;
                    Console.WriteLine(d);
                    break;
                case '-':
                    d = a - c;
                    Console.WriteLine(d);
                    break;
                case '*':
                    d = a * c;
                    Console.WriteLine(d);
                    break;
                case '/':
                    d = a / c;
                    Console.WriteLine(d);
                    break;
            }
            Console.ReadLine();
        }
    }
}
