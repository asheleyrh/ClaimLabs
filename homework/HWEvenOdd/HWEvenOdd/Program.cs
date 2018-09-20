using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter any number");
            Console.ReadKey();
            int num ;
            Console.Write(num);

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("number is even");
            //}
            //else
            //{
            //    Console.WriteLine("number is odd");
            //}
            Console.Write = (num % 2 == 0) ? "even" : "odd";
            Console.ReadKey();
        }
    }
}
