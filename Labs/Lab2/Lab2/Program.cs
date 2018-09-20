using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter age and salary");
            string name = Console.ReadLine();

            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("hi " + name + " you got a bonus of 10%. your new salary is " + (salary / 10 + salary));

            Console.ReadKey(true);
        }
    }
}
