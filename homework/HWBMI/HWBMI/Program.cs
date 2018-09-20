using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter height and weight  ");

            double height = Convert.ToDouble(Console.ReadLine());
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("your BMI = " + (weight / height));

            Console.ReadKey(true);
        }
    }
}
