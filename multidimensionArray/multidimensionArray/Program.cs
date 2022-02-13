using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multidimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] bikes = new string[2, 2]
            {
                {"Honda","Hero"},
                {"Suzuki","KTM"}
            };


            foreach (string val1 in bikes)
            {
                Console.WriteLine(val1);
            }
        }
    }
}
