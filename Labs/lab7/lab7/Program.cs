using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
                Console.Write(name[i]);
            Console.ReadKey();
        }
        
    }
}
