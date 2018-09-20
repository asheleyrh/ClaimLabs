using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int j = 0;
            for (int i = 1; i <= 5; i++) 
            {
              j = j +i;
            }
            Console.WriteLine("sum " + j);
            Console.ReadKey();
        }
        
    }
}
