using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loop
{   
    class Data
    {
        public static string nm;
        public static int age;

        public void getdata()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine(" Enter Name : ");
            nm = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Enter Age : ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        
    }
    class Datadisp : Data
    {
        public void disp()
        {
            Console.WriteLine(" Name : " + Data.nm);
            Console.WriteLine(" Age : " + Data.age);
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            Datadisp d1 = new Datadisp();
            d.getdata();
            d1.disp();
      
            Console.ReadKey(true);
        }
    }
}
