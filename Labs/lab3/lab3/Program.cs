using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number grade");
            
            int score = Convert.ToInt32(Console.ReadLine());
            Console.Write(score);



            if (score >= 0 && score <= 40)
                 {
                     Console.Write("C");
               }
             else if (score >=41 && score <=60)
             {
                 Console.Write("B");
             }
             else if (score >= 61 && score <= 70)
             {
                 Console.Write("B+");
             }
             else if (score >= 71 && score <= 90)
             {
                 Console.Write("A");
             }
            else
             {
                 Console.Write("A+");

             }
            
            Console.ReadKey();
        }
    }
}
