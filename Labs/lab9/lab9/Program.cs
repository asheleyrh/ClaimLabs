using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {for (int i=0; i <=5; i++)
            {

                
                for (int j=0; j<=5; j++)
                {
                    if (j == 0 || i ==5)
                    {
                        Console.Write("*");
                    }
                    
                    
                }
                
                Console.WriteLine();

            } 
            Console.ReadKey();
        }
    }
}
