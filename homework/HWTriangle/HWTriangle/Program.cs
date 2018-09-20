using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the base value of your triangle ");
            decimal bSide = decimal.Parse(Console.ReadLine());
            Console.Write("write the height value of your triangle ");
            decimal hSide = decimal.Parse(Console.ReadLine());

            decimal area = (bSide * hSide) / 2;
            Console.WriteLine("the area of your triangle is {0}", area);

            Console.ReadKey();
        }
    }
}
