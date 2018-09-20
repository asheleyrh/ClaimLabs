using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name and age ");
            string name = Console.ReadLine();

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hi " + name + " your age is " + a + " 5 years from now your age will be " + (a + 5));
            Console.ReadKey(true);
        }
    }
}
