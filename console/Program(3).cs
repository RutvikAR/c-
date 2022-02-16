using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int m1 , m2 ,m3,m4,total;
            Console.WriteLine("Enter your name : ");
            name =  Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Enter your marks :");
            Console.WriteLine("Enter mark 1 :");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark 2 :");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark 3 :");
            m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mark 4 :");
            m4 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3+m4;
            Console.WriteLine("Your total marks : "+total);
            int per = total / 4;
            Console.WriteLine("Your per :"+per);
            
            if (m1>=28 && m2>=28 && m3>=28 && m4>=28)
            {
                
                if(per>=90)
                {
                    Console.Write("Pass with A grade ^-^");
                }
                else if(per>=80)
                {
                    Console.Write("Pass with B grade ^-^");
                }
                else if(per>=70)
                {
                    Console.Write("Pass with C grade ^-^");

                }
                else if(per>=60)
                {
                    Console.Write("Pass with D grade ^-^");
                }
                else if(per>=50)
                {
                    Console.Write("Pass with E grade ^-^");
                }
                else if(per>=40)
                {
                    Console.Write("Pass grade -");
                }
            }
            else
                {
                Console.WriteLine("fail");
                }
            Console.ReadLine();
        }
       
    }
}
