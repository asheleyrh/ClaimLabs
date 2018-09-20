using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number 1-99 for amount of change back");
            int a = Convert.ToInt32(Console.ReadLine());
           

            int Aquarter = a / 25;
            a = a % 25;

            int Adime = a / 10;
            a = a % 10;

            int Anickle = a / 5;
            a = a % 5;

            int Apenny = a / 1;
            a = a % 1;

            Console.WriteLine("the amount of quarters are  {0}", Aquarter);
            Console.WriteLine("the amount of dimes are {0}", Adime);
            Console.WriteLine("the amount of nickles are {0}", Anickle);
            Console.WriteLine("the amount of pennys are {0}", Apenny);
            Console.ReadKey();

        
        }
    }
}
