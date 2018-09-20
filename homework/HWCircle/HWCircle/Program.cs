using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle ");
            double radius = double.Parse(Console.ReadLine());
            double circumference = (2 * Math.PI) * radius;
            Console.WriteLine("the circumference of the circle is {0} ", circumference);

            

            double area = radius* Math.PI / radius;
            Console.WriteLine("area " + area);

            Console.ReadKey(true);
           


        }
    }
}